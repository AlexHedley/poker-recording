using Poker.Common.Models;

namespace Poker.Server.WebApp.Services
{
    /// <summary>
    /// File Service
    /// </summary>
    public class FileService : IFileService
    {
        #region Properties

        private readonly ILogger<FileService> _logger;
        
        private string _path;
        private string _playersPath;
        private string _cardsPath;

        private FileSystemWatcher watcher;

        public Stats stats = new Stats();
        public string FilePath { get { return _path; } }

        #endregion Properties

        public FileService(ILogger<FileService> logger)
        {
            _logger = logger;

            _path = ApplicationSettings.StreamingOptions.Folder;
            var playersFolder = ApplicationSettings.StreamingOptions.PlayersFolder;
            var cardFolder = ApplicationSettings.StreamingOptions.CardFolder;

            _playersPath = Path.Combine(new string[] { _path, playersFolder });
            _cardsPath = Path.Combine(new string[] { _path, cardFolder });

            if (!Directory.Exists(_playersPath)) throw new DirectoryNotFoundException();
            if (!Directory.Exists(_cardsPath)) throw new DirectoryNotFoundException();

            watcher = new FileSystemWatcher(_path);

            SetupWatcher();
        }

        #region Watcher

        public void SetupWatcher()
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

            watcher.Filter = "*.txt";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            _logger.LogDebug("Changed: " + DateTime.Now);
            UpdateStats();
            //InvokeAsync(() => StateHasChanged());
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            string value = $"Created: {e.FullPath}";
            Console.WriteLine(value);
            _logger.LogDebug(value);
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            string value = $"Deleted: {e.FullPath}";
            Console.WriteLine(value);
            _logger.LogDebug(value);
        }
        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Renamed:");
            Console.WriteLine($"    Old: {e.OldFullPath}");
            Console.WriteLine($"    New: {e.FullPath}");
            _logger.LogDebug($"Renamed: Old: {e.OldFullPath} => New: {e.FullPath}");
        }

        #endregion Watcher

        private void UpdateStats()
        {
            stats.Player1 = GetPlayerName("1");
            stats.Player2 = GetPlayerName("2");
            stats.Player3 = GetPlayerName("3");
            stats.Player4 = GetPlayerName("4");

            stats.PotOddsPlayer1 = GetPlayerPotOdds("1");
            stats.PotOddsPlayer2 = GetPlayerPotOdds("2");
            stats.PotOddsPlayer3 = GetPlayerPotOdds("3");
            stats.PotOddsPlayer4 = GetPlayerPotOdds("4");
        }

        private string GetPlayerName(string playerNumber)
        {
            return File.ReadAllText(Path.Combine(_path, $"Player{playerNumber}.txt"));
        }

        private string GetPlayerPotOdds(string playerNumber)
        {
            return File.ReadAllText(Path.Combine(_path, $"PotOddsPlayer{playerNumber}.txt"));
        }
    }
}
