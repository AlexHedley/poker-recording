using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.FluentUI.AspNetCore.Components;

using Poker.Shared;
using Poker.Shared.Services;
using Poker.WebApp.Services;

namespace Poker.WebApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            // Add services to the container.
            
            builder.Services.AddFluentUIComponents();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            //builder.Services.AddHttpClient();
            builder.Services.AddSingleton<IFileService, DemoFileService>();
            builder.Services.AddSingleton<IGameService, GameService>();
            //builder.Services.AddHttpClient<IPokerService, PokerService>();
            builder.Services.AddHttpClient<PokerService>();

            await builder.Build().RunAsync();
        }
    }
}