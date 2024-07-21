using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;

namespace Poker.WebApp.Pages;
public partial class Night
{
    [Inject]
    public required IDialogService DialogService { get; init; }

    WizardStepSequence StepSequence = WizardStepSequence.Linear;
    string Player1 = "Alex";
    string Time;
    string BuyIn;

    void OnStepChange(FluentWizardStepChangeEventArgs e)
    {
        Console.WriteLine($"Go to step {e.TargetLabel} (#{e.TargetIndex})");
    }

    async Task OnFinishedAsync()
    {
        await DialogService.ShowInfoAsync("Enjoy your game 🃏");
    }
}
