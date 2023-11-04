# Camera Web Server

[![Arduino](https://img.shields.io/badge/-Arduino-00979D?style=for-the-badge&logo=Arduino&logoColor=white)](https://www.arduino.cc/)

## Code

From [espressif](https://github.com/espressif/arduino-esp32/tree/master/libraries/ESP32/examples/Camera/CameraWebServer).

- [CameraWebServer.ino](CameraWebServer.ino)
- [secrets.h](secrets.h.example) Example - update

Update `SECRET_SSID` and `SECRET_PASS` with your WIFI login.

`ren secrets.h.example secrets.h`

## View

Open the browser at the _IP address_ shown in the logs.

You will get a window where you can configure the Stream, or you can see it directly at `http://{{IP address}}:81/stream`

## Docs

- [docs](../../docs/CAMERAWEBSERVER.md)

## Links

- [Boards](https://raw.githubusercontent.com/espressif/arduino-esp32/gh-pages/package_esp32_index.json)
