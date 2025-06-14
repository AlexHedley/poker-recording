using Poker.Common;
using Poker.Common.Models;
using Poker.Shared.Services;

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
        private Stats _stats = new Stats();
        private string _playersPath;
        private string _cardsPath;

        private FileSystemWatcher watcher;

        public event Notify ProcessCompleted;

        public Stats Stats { get { return _stats; } }

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
            //InvokeAsync(() => StateHasChanged());
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            string value = $"Created: {e.FullPath}";
            Console.WriteLine(value);
            // _logger.LogDebug(value);
            UpdateStats();
            //InvokeAsync(() => StateHasChanged());
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            string value = $"Deleted: {e.FullPath}";
            Console.WriteLine(value);
            // _logger.LogDebug(value);
            UpdateStats();
            //InvokeAsync(() => StateHasChanged());
        }
        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Renamed:");
            Console.WriteLine($"    Old: {e.OldFullPath}");
            Console.WriteLine($"    New: {e.FullPath}");
            // _logger.LogDebug($"Renamed: Old: {e.OldFullPath} => New: {e.FullPath}");
            UpdateStats();
            //InvokeAsync(() => StateHasChanged());
        }

        #endregion Watcher

        #region Stats Helper

        public void UpdateStats()
        {
            _stats.Player1 = GetPlayerName("1");
            _stats.Player2 = GetPlayerName("2");
            _stats.Player3 = GetPlayerName("3");
            _stats.Player4 = GetPlayerName("4");

            _stats.Player1PotOdds = GetPlayerPotOdds("1");
            _stats.Player2PotOdds = GetPlayerPotOdds("2");
            _stats.Player3PotOdds = GetPlayerPotOdds("3");
            _stats.Player4PotOdds = GetPlayerPotOdds("4");

            _stats.Player1Card1 = GetCard(Constants.Player1Card1);
            _stats.Player1Card2 = GetCard(Constants.Player1Card2);
            _stats.Player2Card1 = GetCard(Constants.Player2Card1);
            _stats.Player2Card2 = GetCard(Constants.Player2Card2);
            _stats.Player3Card1 = GetCard(Constants.Player3Card1);
            _stats.Player3Card2 = GetCard(Constants.Player3Card2);
            _stats.Player4Card1 = GetCard(Constants.Player4Card1);
            _stats.Player4Card2 = GetCard(Constants.Player4Card2);

            _stats.BoardFlopOne = GetCard(Constants.BoardFlopOne);
            _stats.BoardFlopTwo = GetCard(Constants.BoardFlopTwo);
            _stats.BoardFlopThree = GetCard(Constants.BoardFlopThree);
            _stats.BoardTurn = GetCard(Constants.BoardTurn);
            _stats.BoardRiver = GetCard(Constants.BoardRiver);

            _stats.Player1Camera = GetCamera("One");
            _stats.Player2Camera = GetCamera("Two");
            _stats.Player3Camera = GetCamera("Three");
            _stats.Player4Camera = GetCamera("Four");
            _stats.BoardCamera = GetCamera("Five");

            ProcessCompleted?.Invoke();
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

    }
}
