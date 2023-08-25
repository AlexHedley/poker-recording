# Poker

- [code](../src/Poker/)

## Concept

Place a playing card (with an RFID/NFC sticker) on an RFID/NFC reader, this will send a request to this API with the value A♥ (♣♦♠) and the position - Player or board.
This will then update the picture on disc to the correct image, this in turn is already an Image (or Media Source) control in an OBS Scene, so will update to the given image.

<!-- ```mermaid
flowchart LR
    id1[This is the text in the box]
``` -->

### Future

From the cards currently shown, calculate pot odds (can't be guaranteed?).

## Setup

`dotnet new globaljson`

`dotnet new gitignore`

## Run

- http://localhost:5174/swagger/index.html
- https://localhost:7037/swagger/index.html

Try out the requests with [API.http](../src/Poker/Poker.API/API.http).

Update `applicationUrl` to `0.0.0.0` in [launchSettings.json](..\src\Poker\Poker.API\Properties\launchSettings.json) to allow remote connections.

---

## Inspirations

- [MyStreamTimer](https://github.com/jamesmontemagno/MyStreamTimer) from [@JamesMontemagno](https://github.com/jamesmontemagno/)

## Acknowledgements

Poker Icon

- https://www.publicdomainpictures.net/en/free-download.php?image=poker-cards&id=285300
