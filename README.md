# ♥♣♦♠ Poker Recording 📹

> Setup for recording a home poker game

[![Dependabot](https://img.shields.io/badge/dependabot-025E8C?style=for-the-badge&logo=dependabot&logoColor=white)](https://github.com/AlexHedley/poker-recording/security/dependabot)
[![Dependency-Check](https://img.shields.io/badge/DependencyCheck-f78d0a.svg?style=for-the-badge&logo=dependencycheck&logoColor=white)](https://owasp.org/www-project-dependency-check/)

[![Build / Test (with Reports)](https://github.com/AlexHedley/poker-recording/actions/workflows/build-test.yml/badge.svg)](https://github.com/AlexHedley/poker-recording/actions/workflows/build-test.yml)
[![Build Docs](https://github.com/AlexHedley/poker-recording/actions/workflows/build-docs.yml/badge.svg)](https://github.com/AlexHedley/poker-recording/actions/workflows/build-docs.yml)
[![Deploy to GitHub Pages](https://github.com/AlexHedley/poker-recording/actions/workflows/deploy-site.yml/badge.svg)](https://github.com/AlexHedley/poker-recording/actions/workflows/deploy-site.yml)
[![pages-build-deployment](https://github.com/AlexHedley/poker-recording/actions/workflows/pages/pages-build-deployment/badge.svg)](https://github.com/AlexHedley/poker-recording/actions/workflows/pages/pages-build-deployment)
[![CodeQL](https://github.com/AlexHedley/poker-recording/actions/workflows/github-code-scanning/codeql/badge.svg)](https://github.com/AlexHedley/poker-recording/actions/workflows/github-code-scanning/codeql)
[![Dependency Check](https://github.com/AlexHedley/poker-recording/actions/workflows/depcheck.yml/badge.svg)](https://github.com/AlexHedley/poker-recording/actions/workflows/depcheck.yml)
[![Dependabot Updates](https://github.com/AlexHedley/poker-recording/actions/workflows/dependabot/dependabot-updates/badge.svg)](https://github.com/AlexHedley/poker-recording/actions/workflows/dependabot/dependabot-updates)

## Site

-   https://alexhedley.github.io/poker-recording/
-   https://alexhedley.github.io/poker-recording/rfidreader/

[![Video](src/Poker/docs/images/video.png "Video")](https://youtu.be/wJCgOoJmJX0)

## Diagram

```mermaid
flowchart LR
    RFID -->|ID| API
    Camera -->|Stream| Device

    subgraph API
        A[Update Card]
        B[Clear Cards]
    end

    subgraph RFID
        C[RC522] --> D
        D[ESP8266]
    end

    subgraph Camera
        E[OV2640] --> F
        F[ESP32-CAM]
    end
```

## src

[![Arduino](https://img.shields.io/badge/-Arduino-00979D?style=for-the-badge&logo=Arduino&logoColor=white)](https://www.arduino.cc/) [![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/dotnet/csharp/)

-   [src](src/README.md)
    -   📹 [CameraWebServer](src/CameraWebServer/)
    -   🔎 [RFID Reader](src/RFIDReader/)
    -   ♥ [Poker](src/Poker/) API

## Tests

[![Poker API Tests](https://gist.githubusercontent.com/alexhedley/e81db3939d78a6f3bf73f657d803d723/raw/poker_api_tests.md_badge.svg "Poker API Tests")](https://gist.github.com/alexhedley/e81db3939d78a6f3bf73f657d803d723)
[![Poker.WebApp Tests](https://gist.githubusercontent.com/alexhedley/8c84c970be1a96ca94aa5b69ad2b4825/raw/poker_webapp_tests.md_badge.svg "Poker.WebApp Tests")](https://gist.github.com/alexhedley/8c84c970be1a96ca94aa5b69ad2b4825)
[![Poker.Server.WebApp Tests](https://gist.githubusercontent.com/alexhedley/31e5a7dcd73eda1227507917aee86735/raw/poker_server_webapp_tests.md_badge.svg "Poker.Server.WebApp Tests")](https://gist.github.com/alexhedley/31e5a7dcd73eda1227507917aee86735)
[![PokerHandEvaluator Tests](https://gist.githubusercontent.com/alexhedley/56c7effd59d86b0765f710a7e5325857/raw/pokerhandevaluator_tests.md_badge.svg "PokerHandEvaluator Tests")](https://gist.github.com/alexhedley/56c7effd59d86b0765f710a7e5325857)

- [Poker API Tests](https://gist.github.com/alexhedley/e81db3939d78a6f3bf73f657d803d723)
- [Poker.WebApp Tests](https://gist.github.com/AlexHedley/8c84c970be1a96ca94aa5b69ad2b4825)
- [Poker.Server.WebApp Tests](https://gist.github.com/AlexHedley/31e5a7dcd73eda1227507917aee86735)
- [PokerHandEvaluator Tests](https://gist.github.com/AlexHedley/56c7effd59d86b0765f710a7e5325857)
- _Poker.API.PlaywrightTests_

Output using [dotnet-tests-report](https://github.com/marketplace/actions/dotnet-tests-report) ([Code](https://github.com/zyborg/dotnet-tests-report))

## Resources

- [Resources](resources/README.md)

## Docs

- [Docs](docs/README.md)
  - [Progress](docs/progress/README.md) 
  - [CameraWebServer](docs/CAMERAWEBSERVER.md)
  - [RFID Reader](docs/RFID.md)
  - [Poker](docs/POKER.md)

## Blog Posts

- [Poker - Recording Games](https://alexhedley.com/blog/posts/poker-recording-games)
- [Poker - Tracking cards](https://alexhedley.com/blog/posts/poker-tracking-cards)
- [Poker - Table top](https://alexhedley.com/blog/posts/poker-table-top)
- [Poker - Chip](https://alexhedley.com/blog/posts/poker-chip)
- [Poker - API](https://alexhedley.com/blog/posts/poker-api)
- [Poker - Stats](https://alexhedley.com/blog/posts/poker-stats)
- [Poker - App](https://alexhedley.com/blog/posts/poker-app)
- [Poker - Docs](https://alexhedley.com/blog/posts/poker-docs)
- [Poker - HUD](https://alexhedley.com/blog/posts/poker-hud)

## Stats

A website to store all the game information.

- [GitHub](https://github.com/AlexHedley/poker) WIP 
- ([Site](https://alexhedley.com/poker))

## Related

- https://github.com/AlexHedley/poker-hud
- https://github.com/AlexHedley/poker-night

- https://github.com/AlexHedley/PokerOddsPro
- https://github.com/AlexHedley/Poker-Hand-Evaluator
