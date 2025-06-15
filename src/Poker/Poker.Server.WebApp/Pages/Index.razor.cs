using Microsoft.AspNetCore.Components;

using Poker.Common.Models;
using Poker.Shared.Services;

namespace Poker.Server.WebApp.Pages;

public partial class Index
{
    #region Properties

    [Inject]
    PokerService pokerService { get; set; }

    [Inject]
    IGameService gameService { get; set; }

    Game Game { get; set; } = new Game();

    string StreamingOptionsFolder { get; set; }

    #endregion Properties

    protected override void OnInitialized()
    {
        StreamingOptionsFolder = ""; //gameService.fileService.FilePath;

        gameService.InitializeGame();
        Game = gameService.game;
    }

    async Task Reset()
    {
        await pokerService.DeleteAsync();
    }
}
