# Poker

[![C#](https://img.shields.io/badge/c%23-239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)

<!-- [![Poker API Tests](https://gist.githubusercontent.com/alexhedley/###/raw/poker_api_tests.md_badge.svg "Poker API Tests")](https://gist.github.com/alexhedley/###) -->

## Demo

- http://localhost:5174/swagger/index.html

## Solution

| Project                       | Type                  | Info                 |
| ----------------------------- | --------------------- | -------------------- |
| Poker.API                     | Microsoft.NET.Sdk.Web | API                  |
| Poker.API.Tests               | Microsoft.NET.Sdk     | xUnit                |
| Poker.API.PlaywrightTests     | Microsoft.NET.Sdk     | MSTest / Playwright  |
|                               |                       |                      |
| PokerOddsPro.OddsEngine       | Microsoft.NET.Sdk     | Library (dyh1213)    |
| PokerOddsPro.Shared           | Microsoft.NET.Sdk     | Library (dyh1213)    |
| PokerOddsPro.ConsoleApp       | Microsoft.NET.Sdk     | Console              |
|                               |                       |                      |
| PokerHandEvaluator            | Microsoft.NET.Sdk     | Library (danielpaz6) |
| PokerHandEvaluator.ConsoleApp | Microsoft.NET.Sdk     | Console (danielpaz6) |

- xUnit
- NSubstitute
- [log4net](https://logging.apache.org/log4net/)
  - The [Microsoft.Extensions.Logging.Log4Net.AspNetCore](https://github.com/huorswords/Microsoft.Extensions.Logging.Log4Net.AspNetCore) package is written and maintained by Ángel García Santos ([@huorswords](https://github.com/huorswords/))
- Microsoft.Playwright.MSTest

## Tests

[![Poker API Tests](https://gist.githubusercontent.com/alexhedley/e81db3939d78a6f3bf73f657d803d723/raw/poker_api_tests.md_badge.svg "Poker API Tests")](https://gist.github.com/alexhedley/e81db3939d78a6f3bf73f657d803d723)

- [Poker API Tests](https://gist.github.com/alexhedley/e81db3939d78a6f3bf73f657d803d723)

Output using [dotnet-tests-report](https://github.com/marketplace/actions/dotnet-tests-report) ([Code](https://github.com/zyborg/dotnet-tests-report))

### Playwright

- [Playwright](Poker.API.PlaywrightTests/README.md)

## Docs

- [Poker](../../docs/POKER.md)

### Blog

- [Recording Poker Games](https://alexhedley.com/blog/posts/poker-recording-games)
- [Poker - Tracking cards](https://alexhedley.com/blog/posts/poker-tracking-cards)
- [Poker - Table top](https://alexhedley.com/blog/posts/poker-table-top)
