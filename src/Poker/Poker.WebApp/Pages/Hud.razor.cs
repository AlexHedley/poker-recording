using Poker.Components.Models;

namespace Poker.WebApp.Pages;

public partial class Hud
{
    public Player? Player1;
    public Player? Player2;

    //protected override async Task OnInitializedAsync() {}
    protected override void OnInitialized()
    {
        SetupPlayer1();
        SetupPlayer2();
    }

    void SetupPlayer1()
    {
        Player1 = new Player();
        Player1.Card1 = "_content/Poker.Components/images/cards/12-spade.png";
        Player1.Card2 = "_content/Poker.Components/images/cards/11-spade.png";
        Player1.Name = "Gareth";
        Player1.Picture = "_content/Poker.Components/images/players/man1.svg";
        Player1.PotOdds = "100%";
        Player1.Move = "Check";
        Player1.Unknown = "SB";
        Player1.Chips = "869k";
        Player1.Info = "";
        Player1.Flag = "_content/Poker.Components/images/flags/uk.jpg";
    }

    void SetupPlayer2()
    {
        Player2 = new Player();
        Player2.Card1 = "_content/Poker.Components/images/cards/8-spade.png";
        Player2.Card2 = "_content/Poker.Components/images/cards/6-spade.png";
        Player2.Name = "Phil";
        Player2.Picture = "_content/Poker.Components/images/players/man2.svg";
        Player2.PotOdds = "0%";
        Player2.Move = "";
        Player2.Unknown = "+1";
        Player2.Chips = "974k";
        Player2.Info = "Bluff";
        Player2.Flag = "_content/Poker.Components/images/flags/us.jpg";
    }
}
