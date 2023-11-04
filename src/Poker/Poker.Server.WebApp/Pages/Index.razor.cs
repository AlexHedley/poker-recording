using Poker.Server.WebApp.Models;

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

    #endregion Properties

    protected override void OnInitialized()
    {
        Stats = new Stats();
        // FileService.SetupWatcher();
        // _path = FileService.FilePath;

        _configurationRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        _path = _configurationRoot["streaming:folder"];

        var playersFolder = _configurationRoot["streaming:playersFolder"];
        var cardFolder = _configurationRoot["streaming:cardFolder"];

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

        Stats.PotOddsPlayer1 = GetPlayerPotOdds("1");
        Stats.PotOddsPlayer2 = GetPlayerPotOdds("2");
        Stats.PotOddsPlayer3 = GetPlayerPotOdds("3");
        Stats.PotOddsPlayer4 = GetPlayerPotOdds("4");

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

        Stats.Player1Camera = GetCamera("one");
        Stats.Player2Camera = GetCamera("two");
        Stats.Player3Camera = GetCamera("three");
        Stats.Player4Camera = GetCamera("four");
        Stats.BoardCamera = GetCamera("five");
    }

    private string GetPlayerName(string playerNumber)
    {
        var path = Path.Combine(_playersPath, $"Player{playerNumber}.txt");
        // return File.ReadAllText(path);
        using FileStream fs = System.IO.File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read);
        using (StreamReader reader = new StreamReader(fs))
            return reader.ReadToEnd();
    }

    private string GetPlayerPotOdds(string playerNumber)
    {
        var path = Path.Combine(_playersPath, $"PotOddsPlayer{playerNumber}.txt");
        // return File.ReadAllText(path);
        using FileStream fs = System.IO.File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read);
        using (StreamReader reader = new StreamReader(fs))
            return reader.ReadToEnd();
    }

    private string GetCard(string card)
    {
        // return Path.Combine(_playersPath, card);
        return Path.Combine("/", _configurationRoot["streaming:playersFolder"], card) + "?DummyId=" + DateTime.Now.Ticks;
    }

    private string GetCamera(string camera)
    {
        var cameraIP = _configurationRoot[$"cameras:{camera}"];
        // toggle-stream
        // document.getElementById("toggle-stream").click();
        // <img id="stream" src="http://192.168.0.43:81/stream" crossorigin="">

        return $"http://{cameraIP}:81/stream";
    }


    #endregion Stats Helper
}
