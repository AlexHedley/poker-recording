using Microsoft.AspNetCore.Components;

using Poker.Common.Models;
using Poker.Shared.Services;

namespace Poker.Server.WebApp.Pages;

public partial class Index
{
    #region Properties

    // private readonly ILogger<Index> _logger;
    private IConfigurationRoot _configurationRoot;
    private FileSystemWatcher watcher;
    private string _path;
    private string _playersPath;
    private string _cardsPath;

    private Stats Stats;

    [Inject]
    PokerService pokerService { get; set; }

    string StreamingOptionsFolder { get; set; }

    Player Player1 { get; set; } = new Player();
    Player Player2 { get; set; } = new Player();
    Player Player3 { get; set; } = new Player();
    Player Player4 { get; set; } = new Player();


    #endregion Properties

    protected override void OnInitialized()
    {
        Stats = new Stats();
        // FileService.SetupWatcher();
        // _path = FileService.FilePath;

        _path = ApplicationSettings.StreamingOptions.Folder;
        StreamingOptionsFolder = _path;
        var playersFolder = ApplicationSettings.StreamingOptions.PlayersFolder;
        var cardFolder = ApplicationSettings.StreamingOptions.CardFolder;

        _playersPath = Path.Combine(new string[] { _path, playersFolder });
        _cardsPath = Path.Combine(new string[] { _path, cardFolder });

        if (!Directory.Exists(_playersPath)) throw new DirectoryNotFoundException();
        if (!Directory.Exists(_cardsPath)) throw new DirectoryNotFoundException();

        watcher = new FileSystemWatcher(_path);

        SetupWatcher();

        UpdateStats();
    }

    #region Watcher

    void SetupWatcher()
    {
        watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

        watcher.Changed += OnChanged;
        watcher.Created += OnCreated;
        watcher.Deleted += OnDeleted;
        watcher.Renamed += OnRenamed;

        // watcher.Filter = "*.txt";
        watcher.Filters.Add("*.txt");
        watcher.Filters.Add("*.png");
        watcher.IncludeSubdirectories = true;
        watcher.EnableRaisingEvents = true;
    }

    private void OnChanged(object sender, FileSystemEventArgs e)
    {
        string value = "Changed: " + DateTime.Now;
        Console.WriteLine(value);
        // _logger.LogDebug("Changed: " + DateTime.Now);
        UpdateStats();
        InvokeAsync(() => StateHasChanged());
    }

    private void OnCreated(object sender, FileSystemEventArgs e)
    {
        string value = $"Created: {e.FullPath}";
        Console.WriteLine(value);
        // _logger.LogDebug(value);
        UpdateStats();
        InvokeAsync(() => StateHasChanged());
    }

    private void OnDeleted(object sender, FileSystemEventArgs e)
    {
        string value = $"Deleted: {e.FullPath}";
        Console.WriteLine(value);
        // _logger.LogDebug(value);
        UpdateStats();
        InvokeAsync(() => StateHasChanged());
    }
    private void OnRenamed(object sender, RenamedEventArgs e)
    {
        Console.WriteLine($"Renamed:");
        Console.WriteLine($"    Old: {e.OldFullPath}");
        Console.WriteLine($"    New: {e.FullPath}");
        // _logger.LogDebug($"Renamed: Old: {e.OldFullPath} => New: {e.FullPath}");
        UpdateStats();
        InvokeAsync(() => StateHasChanged());
    }

    #endregion Watcher

    #region Stats Helper

    private void UpdateStats()
    {
        Stats.Player1 = GetPlayerName("1");
        Stats.Player2 = GetPlayerName("2");
        Stats.Player3 = GetPlayerName("3");
        Stats.Player4 = GetPlayerName("4");

        Stats.Player1PotOdds = GetPlayerPotOdds("1");
        Stats.Player2PotOdds = GetPlayerPotOdds("2");
        Stats.Player3PotOdds = GetPlayerPotOdds("3");
        Stats.Player4PotOdds = GetPlayerPotOdds("4");

        Stats.Player1Card1 = GetCard(Stats.Player1Card1);
        Stats.Player1Card2 = GetCard(Stats.Player1Card2);
        Stats.Player2Card1 = GetCard(Stats.Player2Card1);
        Stats.Player2Card2 = GetCard(Stats.Player2Card2);
        Stats.Player3Card1 = GetCard(Stats.Player3Card1);
        Stats.Player3Card2 = GetCard(Stats.Player3Card2);
        Stats.Player4Card1 = GetCard(Stats.Player4Card1);
        Stats.Player4Card2 = GetCard(Stats.Player4Card2);

        Stats.BoardFlopOne = GetCard(Stats.BoardFlopOne);
        Stats.BoardFlopTwo = GetCard(Stats.BoardFlopTwo);
        Stats.BoardFlopThree = GetCard(Stats.BoardFlopThree);
        Stats.BoardTurn = GetCard(Stats.BoardTurn);
        Stats.BoardRiver = GetCard(Stats.BoardRiver);

        Stats.Player1Camera = GetCamera("One");
        Stats.Player2Camera = GetCamera("Two");
        Stats.Player3Camera = GetCamera("Three");
        Stats.Player4Camera = GetCamera("Four");
        Stats.BoardCamera = GetCamera("Five");

        // Player 1
        Player1.Id = 1;
        Player1.Name = Stats.Player1;
        Player1.Card1 = Stats.Player1Card1;
        Player1.Card2 = Stats.Player1Card2;
        Player1.PotOdds = Stats.Player1PotOdds;
        Player1.CameraUrl = Stats.Player1Camera;
        Player1.IsDealer = true;
        // Player 2
        Player2.Id = 2;
        Player2.Name = Stats.Player2;
        Player2.Card1 = Stats.Player2Card1;
        Player2.Card2 = Stats.Player2Card2;
        Player2.PotOdds = Stats.Player2PotOdds;
        Player2.CameraUrl = Stats.Player2Camera;
        Player2.IsSmallBlind = true;
        // Player 3
        Player3.Id = 3;
        Player3.Name = Stats.Player3;
        Player3.Card1 = Stats.Player3Card1;
        Player3.Card2 = Stats.Player3Card2;
        Player3.PotOdds = Stats.Player3PotOdds;
        Player3.CameraUrl = Stats.Player3Camera;
        Player3.IsBigBlind = true;
        // Player 4
        Player4.Id = 4;
        Player4.Name = Stats.Player4;
        Player4.Card1 = Stats.Player4Card1;
        Player4.Card2 = Stats.Player4Card2;
        Player4.PotOdds = Stats.Player4PotOdds;
        Player4.CameraUrl = Stats.Player4Camera;
    }

    private string GetPlayerName(string playerNumber)
    {
        var path = Path.Combine(_playersPath, $"Player{playerNumber}.txt");
        using FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read);
        using (StreamReader reader = new StreamReader(fs))
            return reader.ReadToEnd();
    }

    private string GetPlayerPotOdds(string playerNumber)
    {
        var path = Path.Combine(_playersPath, $"PotOddsPlayer{playerNumber}.txt");
        using FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read);
        using (StreamReader reader = new StreamReader(fs))
            return reader.ReadToEnd();
    }

    private string GetCard(string card)
    {
        var playersFolder = ApplicationSettings.StreamingOptions.PlayersFolder;
        var filePath = Path.Combine(playersFolder, card);
        var pathToCheck = Path.Combine(_path, filePath);
        
        // Show backcard if card hasn't been scanned yet.
        if (!File.Exists(pathToCheck))
        {
            filePath = "_content/Poker.Components/images/playingcards_2/Backcard.png";
        }

        return filePath + "?DummyId=" + DateTime.Now.Ticks;
    }

    private string GetCamera(string camera)
    {
        //var cameraIP = _configurationRoot[$"cameras:{camera}"];
        var cameraIPPropertyInfo = ApplicationSettings.CameraOptions.GetType().GetProperty(camera, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.FlattenHierarchy);
        var cameraIP = cameraIPPropertyInfo.GetValue(ApplicationSettings.CameraOptions);

        // document.getElementById("toggle-stream").click();
        // <img id="stream" src="http://192.168.0.43:81/stream" crossorigin="">

        return $"http://{cameraIP}:81/stream";
    }


    #endregion Stats Helper

    async void Reset()
    {
        await pokerService.DeleteAsync().GetAwaiter().GetResult();
    }
}
