using Microsoft.AspNetCore.Components;
using Poker.Common.Models;

namespace Poker.Components.TableComponent;

public partial class TableComponent
{
    #region Properties

    [Parameter]
    public Game Game { get; set; }

    string StreamingOptionsFolder { get; set; }

    #endregion Properties

    protected override void OnInitialized()
    {
        StreamingOptionsFolder = ""; //gameService.fileService.FilePath;
    }

}
