using Microsoft.AspNetCore.Components;

using Poker.Common.Models;
using Poker.Server.WebApp.Services;
using Poker.Shared.Services;

namespace Poker.Server.WebApp.Pages;

public partial class Index
{
    #region Properties

    private IConfigurationRoot _configurationRoot;

    [Inject]
    PokerService pokerService { get; set; }

    [Inject]
    IFileService fileService { get; set; }

    string StreamingOptionsFolder { get; set; }

    Player Player1 { get; set; } = new Player();
    Player Player2 { get; set; } = new Player();
    Player Player3 { get; set; } = new Player();
    Player Player4 { get; set; } = new Player();
    Board Board { get; set; } = new Board();

    #endregion Properties

    protected override void OnInitialized()
    {
        StreamingOptionsFolder = fileService.FilePath;

        fileService.ProcessCompleted += OnProcessCompleted;
        fileService.SetupWatcher();
        fileService.UpdateStats();
    }

    void OnProcessCompleted()
    {
        Stats stats = fileService.Stats;

        // Player 1
        Player1.Id = 1;
        Player1.Name = stats.Player1;
        Player1.Card1 = stats.Player1Card1;
        Player1.Card2 = stats.Player1Card2;
        Player1.PotOdds = stats.Player1PotOdds;
        Player1.CameraUrl = stats.Player1Camera;
        Player1.IsDealer = true;
        // Player 2
        Player2.Id = 2;
        Player2.Name = stats.Player2;
        Player2.Card1 = stats.Player2Card1;
        Player2.Card2 = stats.Player2Card2;
        Player2.PotOdds = stats.Player2PotOdds;
        Player2.CameraUrl = stats.Player2Camera;
        Player2.IsSmallBlind = true;
        // Player 3
        Player3.Id = 3;
        Player3.Name = stats.Player3;
        Player3.Card1 = stats.Player3Card1;
        Player3.Card2 = stats.Player3Card2;
        Player3.PotOdds = stats.Player3PotOdds;
        Player3.CameraUrl = stats.Player3Camera;
        Player3.IsBigBlind = true;
        // Player 4
        Player4.Id = 4;
        Player4.Name = stats.Player4;
        Player4.Card1 = stats.Player4Card1;
        Player4.Card2 = stats.Player4Card2;
        Player4.PotOdds = stats.Player4PotOdds;
        Player4.CameraUrl = stats.Player4Camera;

        // Board
        Board.FlopOne = stats.BoardFlopOne;
        Board.FlopTwo = stats.BoardFlopTwo;
        Board.FlopThree = stats.BoardFlopThree;
        Board.Turn= stats.BoardTurn;
        Board.River = stats.BoardRiver;
        Board.CameraUrl = stats.BoardCamera;
        Board.Pot = "100k";
        Board.SmallBlind = "5k";
        Board.BigBlind = "10k";
    }

    async Task Reset()
    {
        await pokerService.DeleteAsync();
    }
}
