using Poker.Components.Models;

namespace Poker.WebApp.Pages;
public partial class Hud
{
    public Player? Player;

    //protected override async Task OnInitializedAsync() {}
    protected override void OnInitialized()
    {
        SetupPlayer();
    }

    void SetupPlayer()
    {
        Player = new Player();
        Player.Card1 = "_content/Poker.Components/images/cards/12-spade.png";
        Player.Card2 = "_content/Poker.Components/images/cards/11-spade.png";
        Player.Name = "Gareth";
        Player.Picture = "_content/Poker.Components/images/players/man1.svg";
        Player.PotOdds = "100%";
        Player.Move = "Check";
        Player.Unknown = "SB";
        Player.Chips = "869k";
        Player.Info = "Bluff";
        Player.Flag = "_content/Poker.Components/images/flags/us.jpg";
    }
}
