using Poker.Components.Models;

namespace Poker.WebApp.Pages;

public partial class Screen
{
    #region Properties

    private Stats Stats;

    #endregion Properties

    protected override void OnInitialized()
    {
        Stats = new Stats();
        UpdateStats();
    }

    #region Stats Helper

    private void UpdateStats()
    {
        Stats.Player1 = "Alex";
        Stats.Player2 = "Jonathan";
        Stats.Player3 = "Simon";
        Stats.Player4 = "Calum";

        Stats.PotOddsPlayer1 = "66%";
        Stats.PotOddsPlayer2 = "10%";
        Stats.PotOddsPlayer3 = "";
        Stats.PotOddsPlayer4 = "";

        Stats.Player1Card1 = "_content/Poker.Components/images/cards/10-club.png";
        Stats.Player1Card2 = "_content/Poker.Components/images/cards/10-club.png";
        Stats.Player2Card1 = "_content/Poker.Components/images/cards/10-club.png";
        Stats.Player2Card2 = "_content/Poker.Components/images/cards/10-club.png";
        Stats.Player3Card1 = "_content/Poker.Components/images/cards/10-club.png";
        Stats.Player3Card2 = "_content/Poker.Components/images/cards/10-club.png";
        Stats.Player4Card1 = "_content/Poker.Components/images/cards/10-club.png";
        Stats.Player4Card2 = "_content/Poker.Components/images/cards/10-club.png";

        Stats.BoardFlopOne = "_content/Poker.Components/images/cards/10-club.png";
        Stats.BoardFlopTwo = "_content/Poker.Components/images/cards/10-club.png";
        Stats.BoardFlopThree = "_content/Poker.Components/images/cards/10-club.png";
        Stats.BoardTurn = "_content/Poker.Components/images/cards/10-club.png";
        Stats.BoardRiver = "_content/Poker.Components/images/cards/10-club.png";

        Stats.Player1Camera = "http://127.0.0.1:81/stream";
        Stats.Player2Camera = "http://127.0.0.1:81/stream";
        Stats.Player3Camera = "http://127.0.0.1:81/stream";
        Stats.Player4Camera = "http://127.0.0.1:81/stream";
        Stats.BoardCamera = "http://127.0.0.1:81/stream";
    }

    #endregion Stats Helper
}
