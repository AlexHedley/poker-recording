using Microsoft.AspNetCore.Components;
using Poker.Common.Models;
using Poker.Shared.Services;

namespace Poker.Server.WebApp.Components.TableComponent;
public partial class TableComponent
{
    [Inject]
    IGameService gameService { get; set; }

    #region Properties

    Game Game { get; set; } = new Game();

    #endregion Properties

    string StreamingOptionsFolder { get; set; }

    protected override void OnInitialized()
    {
        StreamingOptionsFolder = ""; //gameService.fileService.FilePath;

        gameService.InitializeGame();
        Game = gameService.game;
    }

}
