# Playwright

**MSTest**

`dotnet add package Microsoft.Playwright.MSTest`

`dotnet build`

`pwsh bin/Debug/net7.0/playwright.ps1 install`

_Install the required browsers and operating system dependencies_

`pwsh bin/Debug/net7.0/playwright.ps1 install --with-deps`

- https://playwright.dev/dotnet/docs/intro
- https://playwright.dev/dotnet/docs/api-testing

PlaywrightTests

## Install

```powershell
PS \src\Poker\Poker.API.PlaywrightTests> pwsh bin/Debug/net7.0/playwright.ps1 install
Removing unused browser at C:\Users\Lex\AppData\Local\ms-playwright\chromium-1076
Removing unused browser at C:\Users\Lex\AppData\Local\ms-playwright\firefox-1422
Removing unused browser at C:\Users\Lex\AppData\Local\ms-playwright\webkit-1883
Downloading Chromium 119.0.6045.9 (playwright build v1084) from https://playwright.azureedge.net/builds/chromium/1084/chromium-win64.zip
120.8 Mb [====================] 100% 0.0s
Chromium 119.0.6045.9 (playwright build v1084) downloaded to C:\Users\Lex\AppData\Local\ms-playwright\chromium-1084
Downloading Firefox 118.0.1 (playwright build v1425) from https://playwright.azureedge.net/builds/firefox/1425/firefox-win64.zip
80 Mb [====================] 100% 0.0s
Firefox 118.0.1 (playwright build v1425) downloaded to C:\Users\Lex\AppData\Local\ms-playwright\firefox-1425
Downloading Webkit 17.4 (playwright build v1921) from https://playwright.azureedge.net/builds/webkit/1921/webkit-win64.zip
44.5 Mb [====================] 100% 0.0s
Webkit 17.4 (playwright build v1921) downloaded to C:\Users\Lex\AppData\Local\ms-playwright\webkit-1921
```

## Run

- https://playwright.dev/dotnet/docs/test-runners

```powershell
$env:HEADED="1"
dotnet test
```

```bash
No test is available in \src\Poker\Poker.API.PlaywrightTests\bin\Debug\net7.0\Poker.API.PlaywrightTests.dll. Make sure that test discoverer & executors are registered and platform & framework version settings are appropriate and try again.
```

## Links

- [How to test web applications with Playwright and C# .NET](https://www.twilio.com/blog/test-web-apps-with-playwright-and-csharp-dotnet)

## Errors

```bash
Testhost process for source(s) '\src\Poker\Poker.API.PlaywrightTests\bin\Debug\net7.0\Poker.API.PlaywrightTests.dll' exited with error: A fatal error was encountered. The library 'hostpolicy.dll' required to execute the application was not found in '\src\Poker\Poker.API.PlaywrightTests\bin\Debug\net7.0\'.
Failed to run as a self-contained app.

...\testhost.runtimeconfig.json' was not found.
```

`\src\Poker\Poker.API.PlaywrightTests\bin\Debug\net7.0\`

`dotnet .\Microsoft.Playwright.dll install`

```bash
A fatal error was encountered. The library 'hostpolicy.dll' required to execute the application was not found in '\src\Poker\Poker.API.PlaywrightTests\bin\Debug\net7.0\'.
Failed to run as a self-contained app.
  - The application was run as a self-contained app because '\src\Poker\Poker.API.PlaywrightTests\bin\Debug\net7.0\Microsoft.Playwright.runtimeconfig.json' was not found.
  - If this should be a framework-dependent app, add the '\src\Poker\Poker.API.PlaywrightTests\bin\Debug\net7.0\Microsoft.Playwright.runtimeconfig.json' file and specify the appropriate framework.
```

---

- [Solution: Unable to find .deps.json when running .NET 5 tests in Azure DevOps](https://zimmergren.net/unable-to-find-deps-json-dotnet-azure-devops/)

```xml
<PropertyGroup>
    <ProduceReferenceAssembly>false</ProduceReferenceAssembly>
</PropertyGroup>
```
