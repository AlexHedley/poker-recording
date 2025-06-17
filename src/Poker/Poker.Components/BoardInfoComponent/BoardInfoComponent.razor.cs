using Microsoft.AspNetCore.Components;
using Poker.Common.Models;

namespace Poker.Components.BoardInfoComponent;

public partial class BoardInfoComponent
{
    #region Properties

    [Parameter]
    public Game Game { get; set; }

    #endregion Properties

    protected override void OnInitialized()
    {
    }
}
