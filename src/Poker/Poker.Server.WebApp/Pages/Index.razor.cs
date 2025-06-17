using Microsoft.AspNetCore.Components;

using Poker.Common.Models;
using Poker.Shared.Services;

namespace Poker.Server.WebApp.Pages;

public partial class Index
{
    [Inject]
    PokerService PokerService { get; set; }

    [Inject]
    IGameService GameService { get; set; }

    #region Properties

    Game Game { get; set; } = new Game();

    string StreamingOptionsFolder { get; set; }

    #endregion Properties

    protected override void OnInitialized()
    {
        StreamingOptionsFolder = ""; //gameService.fileService.FilePath;

        GameService.InitializeGame();
        Game = GameService.game;
    }

    async Task Reset()
    {
        await PokerService.DeleteAsync();
    }
}
