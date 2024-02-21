# RFID Reader

[![Arduino](https://img.shields.io/badge/-Arduino-00979D?style=for-the-badge&logo=Arduino&logoColor=white)](https://www.arduino.cc/)

## Setup

- ESP8266 Boards (2.7.1)
- NodeMCU 1.0 (ESP-12E Module)
- COM4

## Code

Update `SECRET_SSID` and `SECRET_PASS` with your WIFI login.

`ren secrets.h.example secrets.h`

- [ESP8266.ino](ESP8266/ESP8266.ino)
- [secrets.h](ESP8266/secrets.h)
- [secrets.h.example](ESP8266/secrets.h.example)

## Docs

- [docs](../../docs/RFID.md)

## Links

- [Boards](http://arduino.esp8266.com/stable/package_esp8266com_index.json)

## Run

Scan

Card

```bash
09:02:04.938 -> PICC type: MIFARE 1KB
09:02:04.938 -> A new card has been detected.
09:02:04.938 -> The NUID tag is:
09:02:04.938 -> In hex:  89 65 45 16
09:02:04.938 -> In dec:  137 101 69 22
```

Tag

```bash
09:03:20.124 -> A new card has been detected.
09:03:20.124 -> The NUID tag is:
09:03:20.124 -> In hex:  6A 5C 30 81
09:03:20.124 -> In dec:  106 92 48 129
```

If you re-scan the _device_ you will get:

```bash
09:03:12.738 -> PICC type: MIFARE 1KB
09:03:12.738 -> Card read previously.
```

<details>
<summary>Upload</summary>

```bash
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
Compressed 276288 bytes to 202997...
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
Wrote 276288 bytes (202997 compressed) at 0x00000000 in 19.9 seconds (effective 111.3 kbit/s)...
Hash of data verified.

Leaving...
Hard resetting via RTS pin...
```

</details>

## Verify

In red

<details>
<summary>Verify</summary>

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
```

</details>
