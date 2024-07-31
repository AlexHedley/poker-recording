using Microsoft.AspNetCore.Components;

namespace Poker.Components;

public partial class Pot4
{
    [Parameter]
    public int? Pot { get; set; }
    [Parameter]
    public int SmallBlind { get; set; }
    [Parameter]
    public int BigBlind { get; set; }
}
