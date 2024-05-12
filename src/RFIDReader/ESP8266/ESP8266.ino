/**
 * @file ESP8266.ino
 *
 * @mainpage RFID Reader and API
 *
 * @section description Description
 * A sketch that reads an RFID chip and then sends the id to a custom API.
 *
 * @section circuit Circuit
 * - D0  | D5  | D6 | D7   | D8  | GND | VIN
 * - RST | SCK | MI | MOSI | SDA | GND | 3.3
 *
 * @section libraries Libraries
 * - ESP8266WiFi (https://arduino-esp8266.readthedocs.io/en/latest/esp8266wifi/readme.html)
 * - ESP8266HTTPClient (https://github.com/esp8266/Arduino/blob/master/libraries/ESP8266HTTPClient/src/ESP8266HTTPClient.h)
 * - MFRC522 (https://github.com/miguelbalboa/rfid)
 * - SPI (https://www.arduino.cc/reference/en/language/functions/communication/spi/)
 * - WiFiClient (https://www.arduino.cc/reference/en/libraries/wifi/wificlient/)
 *
 * @section notes Notes
 * - Update PLAYER to the necessary number.
 * - Update serverName to your deployed Poker API.
 * - Update the Secrets.h to your own Wifi usr/pwd.
 *
 * @section author Author
 * - Created by Alex Hedley on 19/11/2023.
 *
 * Copyright (c) 2023 Alex Hedley.  All rights reserved.
 */

#include <ESP8266WiFi.h>
#include <ESP8266HTTPClient.h>
#include <MFRC522.h>
#include <SPI.h>
#include <WiFiClient.h>

#ifndef DOXYGEN_SHOULD_SKIP_THIS

#include "secrets.h"
const char* ssid = SECRET_SSID;
const char* password = SECRET_PASS;

#endif /* DOXYGEN_SHOULD_SKIP_THIS */

#define SS_PIN D8
#define RST_PIN D0

MFRC522 rfid(SS_PIN, RST_PIN); // Instance of the class

MFRC522::MIFARE_Key key;

// Init array that will store new NUID
byte nuidPICC[4];

String serverName = "http://192.168.0.20:5174/api/Poker";
// String serverName = "https://192.168.0.20:7037/api/Poker";

#define PLAYER 1

// the following variables are unsigned longs because the time, measured in
// milliseconds, will quickly become a bigger number than can be stored in an int.
unsigned long lastTime = 0;
// Timer set to 10 minutes (600000)
//unsigned long timerDelay = 600000;
// Set timer to 5 seconds (5000)
unsigned long timerDelay = 5000;

/**
 * Setup
 */
void setup() {
  Serial.begin(115200);

  WiFi.begin(ssid, password);
  Serial.println("Connecting");
  while(WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  Serial.println("");
  Serial.print("Connected to WiFi network with IP Address: ");
  Serial.println(WiFi.localIP());

  Serial.println("Timer set to 5 seconds (timerDelay variable), it will take 5 seconds before publishing the first reading.");

  SPI.begin(); // Init SPI bus
  rfid.PCD_Init(); // Init MFRC522
  Serial.println();
  Serial.print(F("Reader :"));
  rfid.PCD_DumpVersionToSerial();

  for (byte i = 0; i < 6; i++) {
    key.keyByte[i] = 0xFF;
  }
  Serial.println();
  Serial.println(F("This code scan the MIFARE Classic NUID."));
  Serial.print(F("Using the following key:"));
  printHex(key.keyByte, MFRC522::MF_KEY_SIZE);
}

/**
 * Loop
 */
void loop() {
  scanCard();
}

/**
 * Send Card Info
 * 
 * @param card The id of the card you scanned.
 */
void sendCardInfo(String card) {
    // Send an HTTP POST request depending on timerDelay
  if ((millis() - lastTime) > timerDelay) {
    //Check WiFi connection status
    if (WiFi.status() == WL_CONNECTED){
      WiFiClient client;
      HTTPClient http;

      // PUT http://{{hostname}}:{{port}}/api/Poker?player=1&text=AC
      String serverPath = serverName + "?player=" + PLAYER + "&text=" + card;
      Serial.println(serverPath);

      // Your Domain name with URL path or IP address with path
      http.begin(client, serverPath.c_str());
      http.addHeader("Content-Type", "application/json");

      // Send HTTP GET request
      int httpResponseCode = http.PUT("PUT sent from ESP8266");

      if (httpResponseCode > 0) {
        Serial.print("HTTP Response code: ");
        Serial.println(httpResponseCode);
        String payload = http.getString();
        Serial.println(payload);
      }
      else {
        Serial.print("Error code: ");
        Serial.println(httpResponseCode);
        Serial.println(http.errorToString(httpResponseCode).c_str());
      }
      // Free resources
      http.end();
    }
    else {
      Serial.println("WiFi Disconnected");
    }
    lastTime = millis();
  }
}

/**
 * Check for readings from scanning card
 */
void scanCard() {
    // Reset the loop if no new card present on the sensor/reader. This saves the entire process when idle.
  if ( ! rfid.PICC_IsNewCardPresent())
    return;

  // Verify if the NUID has been readed
  if ( ! rfid.PICC_ReadCardSerial()) {
    Serial.println("Bad read (was card removed too quickly?)");
    return;
  }

  Serial.print(F("PICC type: "));
  MFRC522::PICC_Type piccType = rfid.PICC_GetType(rfid.uid.sak);
  Serial.println(rfid.PICC_GetTypeName(piccType));

  if (rfid.uid.uidByte[0] != nuidPICC[0] ||
      rfid.uid.uidByte[1] != nuidPICC[1] ||
      rfid.uid.uidByte[2] != nuidPICC[2] ||
      rfid.uid.uidByte[3] != nuidPICC[3] ) {
    Serial.println(F("A new card has been detected."));

    // Store NUID into nuidPICC array
    for (byte i = 0; i < 4; i++) {
      nuidPICC[i] = rfid.uid.uidByte[i];
    }

    Serial.println(F("The NUID tag is:"));
    Serial.print(F("In hex: "));
    printHex(rfid.uid.uidByte, rfid.uid.size);
    Serial.println();
    Serial.print(F("In dec: "));
    printDec(rfid.uid.uidByte, rfid.uid.size);
    Serial.println();

    String cardid = getCard(rfid.uid.uidByte, rfid.uid.size, HEX);
    Serial.println(cardid);

    sendCardInfo(cardid);
  }
  else {
    Serial.println(F("Card read previously."));
  }

  // Halt PICC (disengage with the card.)
  rfid.PICC_HaltA();

  // Stop encryption on PCD
  rfid.PCD_StopCrypto1();
}

/**
 * Get Card
 * Get card value by HEX or DEC
 * 
 * @param buffer .
 * @param bufferSize .
 * @param format HEX or DEC
 */
String getCard(byte *buffer, byte bufferSize, int format) {
  String cardid;

  for (byte i = 0; i < bufferSize; i++) {
    // cardid += "0x" + String(buffer[i], format) + " ";
    // cardid += String(buffer[i], format) + " ";
    cardid += String(buffer[i] < 0x10 ? "0" : "");
    cardid += String(buffer[i], format);
  }

  return cardid;
}

/**
 * Helper routine to dump a byte array as hex values to Serial.
 */
void printHex(byte *buffer, byte bufferSize) {
  for (byte i = 0; i < bufferSize; i++) {
    Serial.print(buffer[i] < 0x10 ? " 0" : " ");
    Serial.print(buffer[i], HEX);
  }
}

/**
 * Helper routine to dump a byte array as dec values to Serial.
 */
void printDec(byte *buffer, byte bufferSize) {
  for (byte i = 0; i < bufferSize; i++) {
    Serial.print(buffer[i] < 0x10 ? " 0" : " ");
    Serial.print(buffer[i], DEC);
  }
}