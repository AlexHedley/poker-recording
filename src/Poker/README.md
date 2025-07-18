# Poker

[![C#](https://img.shields.io/badge/c%23-239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)

<!-- [![Poker API Tests](https://gist.githubusercontent.com/alexhedley/###/raw/poker_api_tests.md_badge.svg "Poker API Tests")](https://gist.github.com/alexhedley/###) -->

## Demo

- API http://localhost:5174/swagger/index.html

## Solution

- [Poker.sln](Poker.sln)
- [Poker.API.sln](Poker.API.sln)
- [Poker.Server.WebApp.sln](Poker.Server.WebApp.sln)
- [Poker.WebApp.sln](Poker.WebApp.sln)
- [PokerHandEvaluator.sln](PokerHandEvaluator.sln)
- [PokerOddsPro.sln](PokerOddsPro.sln)

| Project                       | Type                                | Info                 |
| ----------------------------- | ----------------------------------- | -------------------- |
| Poker.Common                  | Microsoft.NET.Sdk                   | Library              |
|                               |                                     |                      |
| Poker.API                     | Microsoft.NET.Sdk.Web               | API                  |
| Poker.API.Tests               | Microsoft.NET.Sdk                   | xUnit                |
|                               |                                     |                      |
| Poker.Server.WebApp           | Microsoft.NET.Sdk.Web               | Web                  |
| Poker.Server.WebApp.Tests     | Microsoft.NET.Sdk                   |                      |
| Poker.WebApp                  | Microsoft.NET.Sdk.BlazorWebAssembly | Web                  |
| Poker.WebApp.Tests            | Microsoft.NET.Sdk                   |                      |
| Poker.Components              | Microsoft.NET.Sdk.Razor             | Library              |
| Poker.Shared                  | Microsoft.NET.Sdk.Razor             | Library              |
|                               |                                     |                      |
| PokerOddsPro.OddsEngine       | Microsoft.NET.Sdk                   | Library (dyh1213)    |
| PokerOddsPro.Shared           | Microsoft.NET.Sdk                   | Library (dyh1213)    |
| PokerOddsPro.ConsoleApp       | Microsoft.NET.Sdk                   | Console              |
| PokerOddsPro.WebAssembly      | Microsoft.NET.Sdk.BlazorWebAssembly | WASM                 |
|                               |                                     |                      |
| PokerHandEvaluator            | Microsoft.NET.Sdk                   | Library (danielpaz6) |
| PokerHandEvaluator.ConsoleApp | Microsoft.NET.Sdk                   | Console (danielpaz6) |
| PokerHandEvaluator.Tests      | Microsoft.NET.Sdk                   | xUnit                |
| PokerHandEvaluator.Web        | Microsoft.NET.Sdk.BlazorWebAssembly | WASM                 |

- xUnit
- NSubstitute
- [log4net](https://logging.apache.org/log4net/)
  - The [Microsoft.Extensions.Logging.Log4Net.AspNetCore](https://github.com/huorswords/Microsoft.Extensions.Logging.Log4Net.AspNetCore) package is written and maintained by Ángel García Santos ([@huorswords](https://github.com/huorswords/))

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

## Docs

- [More](docs/README.md)
- [Poker](../../docs/POKER.md)

### Blog

-   [Poker - Recording Games](https://alexhedley.com/blog/posts/poker-recording-games)
-   [Poker - Tracking cards](https://alexhedley.com/blog/posts/poker-tracking-cards)
-   [Poker - Table top](https://alexhedley.com/blog/posts/poker-table-top)
-   [Poker - Chip](https://alexhedley.com/blog/posts/poker-chip)
-   [Poker - API](https://alexhedley.com/blog/posts/poker-api)
-   [Poker - Stats](https://alexhedley.com/blog/posts/poker-stats)
-   [Poker - App](https://alexhedley.com/blog/posts/poker-app)
-   [Poker - Docs](https://alexhedley.com/blog/posts/poker-docs)
-   [Poker - HUD](https://alexhedley.com/blog/posts/poker-hud)
