# RFID

How to Decode RFID Cards with RC522 RFID Reader: Step-by-Step Tutorial

https://www.youtube.com/watch?v=8AZOSQSpUsc

SME Dehradun

<iframe width="560" height="315" src="https://www.youtube.com/embed/8AZOSQSpUsc" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" allowfullscreen></iframe>

https://www.youtube.com/@SMEDehradun

Code
https://github.com/itsbhupendrasingh/RFID-Card-Decoding-RC522/blob/Master/RFID_RC522_decoding/RFID_RC522_decoding.ino

Install library

Tools | Manage Libraries... (Ctrl+Shift+I)
MFRC522

9600 Baud

---

Using an RFID module with an ESP8266

https://www.aranacorp.com/en/using-an-rfid-module-with-an-esp8266/

MFRC522
https://github.com/miguelbalboa/rfid

---

http://arduino.esp8266.com/stable/package_esp8266com_index.json, https://dl.espressif.com/dl/package_esp32_index.json

ESP8266 Boards (2.7.1)
NodeMCU 1.0 (ESP-12E Module)

COM1

```bash
. Variables and constants in RAM (global, static), used 28276 / 80192 bytes (35%)
║   SEGMENT  BYTES    DESCRIPTION
╠══ DATA     1496     initialized variables
╠══ RODATA   988      constants       
╚══ BSS      25792    zeroed variables
. Instruction RAM (IRAM_ATTR, ICACHE_RAM_ATTR), used 60331 / 65536 bytes (92%)
║   SEGMENT  BYTES    DESCRIPTION
╠══ ICACHE   32768    reserved space for flash instruction cache
╚══ IRAM     27563    code in IRAM    
. Code in flash (default, ICACHE_FLASH_ATTR), used 242096 / 1048576 bytes (23%)
║   SEGMENT  BYTES    DESCRIPTION
╚══ IROM     242096   code in flash   
esptool.py v3.0
Serial port COM1
Connecting........_____....._____....._____....._____....._____....._____....._____

A fatal esptool.py error occurred: Failed to connect to ESP8266: Timed out waiting for packet header
```

COM4

```bash
. Variables and constants in RAM (global, static), used 28276 / 80192 bytes (35%)
║   SEGMENT  BYTES    DESCRIPTION
╠══ DATA     1496     initialized variables
╠══ RODATA   988      constants       
╚══ BSS      25792    zeroed variables
. Instruction RAM (IRAM_ATTR, ICACHE_RAM_ATTR), used 60331 / 65536 bytes (92%)
║   SEGMENT  BYTES    DESCRIPTION
╠══ ICACHE   32768    reserved space for flash instruction cache
╚══ IRAM     27563    code in IRAM    
. Code in flash (default, ICACHE_FLASH_ATTR), used 242096 / 1048576 bytes (23%)
║   SEGMENT  BYTES    DESCRIPTION
╚══ IROM     242096   code in flash   
esptool.py v3.0
Serial port COM4
Connecting....
Chip is ESP8266EX
Features: WiFi
Crystal is 26MHz
MAC: f4:cf:a2:d0:48:e7
Uploading stub...
Running stub...
Stub running...
Configuring flash size...
Auto-detected Flash size: 4MB
Compressed 276288 bytes to 202996...
Writing at 0x00000000... (7 %)
Writing at 0x00004000... (15 %)
Writing at 0x00008000... (23 %)
Writing at 0x0000c000... (30 %)
Writing at 0x00010000... (38 %)
Writing at 0x00014000... (46 %)
Writing at 0x00018000... (53 %)
Writing at 0x0001c000... (61 %)
Writing at 0x00020000... (69 %)
Writing at 0x00024000... (76 %)
Writing at 0x00028000... (84 %)
Writing at 0x0002c000... (92 %)
Writing at 0x00030000... (100 %)
Wrote 276288 bytes (202996 compressed) at 0x00000000 in 19.8 seconds (effective 111.4 kbit/s)...
Hash of data verified.

Leaving...
Hard resetting via RTS pin...
```

```bash
14:59:30.731 -> chksum 0x2b
14:59:30.731 -> csum 0x2b
14:59:30.731 -> v00043740
14:59:30.731 -> ~ld
14:59:30.810 -> ����n�s��N|�$�l`c���{��l�N��N�d �n�l�l2��PICC type: MIFARE 1KB
15:00:05.729 -> A new card has been detected.
15:00:05.729 -> The NUID tag is:
15:00:05.764 -> In hex:  6A 5C 30 81
15:00:05.764 -> In dec:  106 92 48 129
15:00:07.128 -> PICC type: MIFARE 1KB
15:00:07.128 -> Card read previously.
15:00:10.582 -> PICC type: MIFARE 1KB
15:00:10.582 -> A new card has been detected.
15:00:10.582 -> The NUID tag is:
15:00:10.582 -> In hex:  89 65 45 16
15:00:10.582 -> In dec:  137 101 69 22
15:00:13.479 -> PICC type: MIFARE 1KB
15:00:13.479 -> Card read previously.
```

---

