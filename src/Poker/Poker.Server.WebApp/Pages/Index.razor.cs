using Microsoft.AspNetCore.Components;

using Poker.Common.Models;
using Poker.Shared.Services;

namespace Poker.Server.WebApp.Pages;

public partial class Index
{
    [Inject]
    PokerService pokerService { get; set; }

    #region Properties

    string StreamingOptionsFolder { get; set; }

    #endregion Properties

    protected override void OnInitialized()
    {
        StreamingOptionsFolder = ""; //gameService.fileService.FilePath;
    }

    async Task Reset()
    {
        await pokerService.DeleteAsync();
    }
}
