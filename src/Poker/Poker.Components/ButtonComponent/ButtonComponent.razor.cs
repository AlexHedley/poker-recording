using Microsoft.AspNetCore.Components;
using Poker.Common.Enums;

namespace Poker.Components.ButtonComponent;
public partial class ButtonComponent
{
    #region Properties

    [Parameter]
    public ButtonType ButtonType { get; set; }

    #endregion Properties

    protected override void OnInitialized()
    {
    }
}
