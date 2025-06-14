using Microsoft.AspNetCore.Components;

namespace Poker.Server.WebApp.Components.CameraComponent;

public partial class CameraComponent
{
    [Parameter]
    public string? Src { get; set; }

    //private string? _src;

    //protected override void OnInitialized() { }
}
