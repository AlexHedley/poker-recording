using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.FileProviders;
using Poker.Server.WebApp.Services;
using Poker.Shared.Services;
using System.Diagnostics;

namespace Poker.Server.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddHttpClient();
            builder.Services.AddSingleton<IFileService, FileService>();
            builder.Services.AddHttpClient<PokerService>();

            // Configuration
            builder.Configuration.GetSection(ApplicationSettings.StreamingUrl).Bind(ApplicationSettings.StreamingOptions);
            builder.Configuration.GetSection(ApplicationSettings.CamerasUrl).Bind(ApplicationSettings.CameraOptions);

            var provider = builder.Services.BuildServiceProvider();
            var _configuration = provider.GetRequiredService<IConfiguration>();
            var streamingSection = _configuration.GetSection("Streaming");
            var folder = streamingSection.GetValue<string>("folder");
            var playersFolder = streamingSection.GetValue<string>("playersFolder");
            var path = Path.Combine(folder, playersFolder);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseStaticFiles(new StaticFileOptions
            {
                RequestPath = "/players",
                FileProvider = new PhysicalFileProvider(path)
            });

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}