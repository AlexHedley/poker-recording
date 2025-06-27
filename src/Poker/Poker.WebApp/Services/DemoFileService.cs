using Poker.Common.Models;
using Poker.Shared.Services;

namespace Poker.WebApp.Services
{
    public class DemoFileService : IFileService
    {
        #region Properties

        private readonly ILogger<DemoFileService> _logger;

        private string _path = String.Empty;
        private Stats _stats = new Stats();

        public Stats Stats { get { return _stats; } }

        public string FilePath { get { return _path; } }
        
        public event Notify ProcessCompleted;

        #endregion Properties

        public DemoFileService(ILogger<DemoFileService> logger)
        {
            _logger = logger;

            // Don't need this
            //SetupWatcher();

            UpdateStats();
        }

        public void SetupWatcher()
        {
            Console.WriteLine("Not needed in WASM");
        }

        public void UpdateStats()
        {
            Stats.Player1 = "Alex";
            Stats.Player2 = "Jonathan";
            Stats.Player3 = "Simon";
            Stats.Player4 = "Calum";

            Stats.Player1PotOdds = "66%";
            Stats.Player2PotOdds = "10%";
            Stats.Player3PotOdds = "";
            Stats.Player4PotOdds = "";

            //Stats.Player1Card1 = "_content/Poker.Components/images/cards/10-club.png";
            Stats.Player1Card1 = "_content/Poker.Components/images/mini/C10.svg";
            Stats.Player1Card2 = "_content/Poker.Components/images/cards/10-club.png";
            Stats.Player2Card1 = "_content/Poker.Components/images/cards/10-club.png";
            Stats.Player2Card2 = "_content/Poker.Components/images/cards/10-club.png";
            Stats.Player3Card1 = "_content/Poker.Components/images/cards/10-club.png";
            Stats.Player3Card2 = "_content/Poker.Components/images/cards/10-club.png";
            Stats.Player4Card1 = "_content/Poker.Components/images/cards/10-club.png";
            Stats.Player4Card2 = "_content/Poker.Components/images/cards/10-club.png";

            Stats.BoardFlopOne = "_content/Poker.Components/images/cards/10-club.png";
            Stats.BoardFlopTwo = "_content/Poker.Components/images/cards/10-club.png";
            Stats.BoardFlopThree = "_content/Poker.Components/images/cards/10-club.png";
            Stats.BoardTurn = "_content/Poker.Components/images/cards/10-club.png";
            Stats.BoardRiver = "_content/Poker.Components/images/cards/10-club.png";

            Stats.Player1Camera = "http://127.0.0.1:81/stream";
            Stats.Player2Camera = "http://127.0.0.1:81/stream";
            Stats.Player3Camera = "http://127.0.0.1:81/stream";
            Stats.Player4Camera = "http://127.0.0.1:81/stream";
            Stats.BoardCamera = "http://127.0.0.1:81/stream";

            ProcessCompleted?.Invoke();
        }
    }
}
