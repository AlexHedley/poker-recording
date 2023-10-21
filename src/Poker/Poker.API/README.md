# Poker.API

Run the sample requests using [API.http](API.http)

## Swagger

- http://localhost:5174/swagger/index.html
- https://localhost:7037/swagger/index.html
- https://localhost:44330/swagger/index.html

## Settings

There are various [appsettings.json](appsettings.json) you need to configure

- [streaming.folder](D:\Twitch\Scenes\Poker)

## Configure

TODO: Create a script or get the app to do this?

Create two sub folders:

- **cards**
  - all cards from all suites
- **players**
  - BoardFlop{1-3}.png
  - BoardTurn.png
  - BoardRiver.png
  - P{1-4}C{1-2}.png
  - Player1.txt (Alex)
  - PotOddsPlayer1.txt (25%)

## Logs

Logs folder of `D:\temp\poker` from [log4net.config](log4net.config)

- [Poker.API.log](D:\temp\poker\Poker.API.log)
