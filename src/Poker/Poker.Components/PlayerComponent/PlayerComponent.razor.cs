using Microsoft.AspNetCore.Components;
using Poker.Common.Models;

namespace Poker.Components.PlayerComponent;

public partial class PlayerComponent
{
    [Parameter]
    public Player PlayerDetails { get; set; }
    public Stats Stats { get; set; } = new Stats();

    //private string? _playerDetails;

    //protected override void OnInitialized() { }
}
