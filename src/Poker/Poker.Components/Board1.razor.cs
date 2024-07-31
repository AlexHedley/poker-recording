using Microsoft.AspNetCore.Components;

namespace Poker.Components;

public partial class Board1
{
    [Parameter]
    public string? BoardFlopOne { get; set; }

    [Parameter]
    public string? BoardFlopTwo { get; set; }

    [Parameter]
    public string? BoardFlopThree { get; set; }

    [Parameter]
    public string? BoardTurn { get; set; }

    [Parameter]
    public string? BoardRiver { get; set; }

    //private string? _boardFlopOne;
    //private string? _boardFlopTwo;
    //private string? _boardFlopThree;
    //private string? _boardTurn;
    //private string? _boardRiver;

    //protected override void OnInitialized() { }
}
