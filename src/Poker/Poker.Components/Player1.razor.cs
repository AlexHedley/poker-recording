using Microsoft.AspNetCore.Components;

using Poker.Common.Models;

namespace Poker.Components;

public partial class Player1
{
    [Parameter]
    public Player? Player { get; set; }

    //protected override void OnInitialized() { }
}
