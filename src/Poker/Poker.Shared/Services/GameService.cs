using Poker.Common.Models;
using PokerHandEvaluator;

namespace Poker.Shared.Services
{
    public class GameService : IGameService
    {
        #region Properties

        //[Inject]
        IFileService fileService { get; set; }

        public Game game { get; set; } = new Game();

        #endregion Properties

        public GameService(IFileService fileService)
        {
            this.fileService = fileService;
        }

        public void InitializeGame()
        {
            // Logic to initialize the board can be added here
            // For example, setting up initial cards or player states
            fileService.ProcessCompleted += OnProcessCompleted;
            // Is this needed if it's called in FileService Constructor??
            //fileService.SetupWatcher();
            fileService.UpdateStats();
        }

        private void OnProcessCompleted()
        {
            // This method will be called when the file watcher detects changes
            // Update the board state based on the new stats
            UpdateBoard();
            EvaluatePokerHand();
        }

        private void UpdateBoard()
        {
            // Logic to update the board state based on game actions
            // This could include adding cards, updating player states, etc.
            Stats stats = fileService.Stats;

            game = new Game
            {
                Player1 = new Player(),
                Player2 = new Player(),
                Player3 = new Player(),
                Player4 = new Player(),
                Board = new Board()
            };

            // Player 1
            game.Player1.Id = 1;
            game.Player1.Name = stats.Player1;
            game.Player1.Card1 = stats.Player1Card1;
            game.Player1.Card2 = stats.Player1Card2;
            game.Player1.PotOdds = stats.Player1PotOdds;
            game.Player1.Picture = "_content/Poker.Components/images/players/man1.svg";
            game.Player1.Flag = "_content/Poker.Components/images/flags/uk.jpg";
            game.Player1.Chips = "100k";
            game.Player1.Move = "Call";
            game.Player1.CameraUrl = stats.Player1Camera;
            game.Player1.IsDealer = true;

            // Player 2
            game.Player2.Id = 2;
            game.Player2.Name = stats.Player2;
            game.Player2.Card1 = stats.Player2Card1;
            game.Player2.Card2 = stats.Player2Card2;
            game.Player2.PotOdds = stats.Player2PotOdds;
            game.Player2.CameraUrl = stats.Player2Camera;
            game.Player2.IsSmallBlind = true;

            // Player 3
            game.Player3.Id = 3;
            game.Player3.Name = stats.Player3;
            game.Player3.Card1 = stats.Player3Card1;
            game.Player3.Card2 = stats.Player3Card2;
            game.Player3.PotOdds = stats.Player3PotOdds;
            game.Player3.CameraUrl = stats.Player3Camera;
            game.Player3.IsBigBlind = true;

            // Player 4
            game.Player4.Id = 4;
            game.Player4.Name = stats.Player4;
            game.Player4.Card1 = stats.Player4Card1;
            game.Player4.Card2 = stats.Player4Card2;
            game.Player4.PotOdds = stats.Player4PotOdds;
            game.Player4.CameraUrl = stats.Player4Camera;

            // Board
            game.Board.FlopOne = stats.BoardFlopOne;
            game.Board.FlopTwo = stats.BoardFlopTwo;
            game.Board.FlopThree = stats.BoardFlopThree;
            game.Board.Turn = stats.BoardTurn;
            game.Board.River = stats.BoardRiver;
            game.Board.CameraUrl = stats.BoardCamera;
            game.Board.Pot = "100k";
            game.Board.SmallBlind = "5k";
            game.Board.BigBlind = "10k";
            game.Board.Ante = "1k";
        }

        void EvaluatePokerHand()
        {
            // Suits: club (♣), diamond (♦), heart (♥) and spade (♠).
            Room room = new Room
            {
                RoomName = "Test Room",
                CardsOnTable = new List<string[]>
                {
                    new string[]{"14", "Club"},
                    new string[]{"13", "Club"},
                    new string[]{"11", "Club"},
                    new string[]{"5", "Club"},
                    new string[]{"10", "Heart" }
                }
            };

            ApplicationUser user1 = new ApplicationUser
            {
                Name = game.Player1.Name, // "A",
                PlayerCards = new List<string[]>
                {
                    new string[]{"8", "Club"},
                    new string[]{"7", "Heart"},
                },
                Chips = 0
            };

            ApplicationUser user2 = new ApplicationUser
            {
                Name = game.Player2.Name, // "B",
                PlayerCards = new List<string[]>
                {
                    new string[]{"9", "Heart"},
                    new string[]{"5", "Heart"},
                },
                Chips = 0
            };

            ApplicationUser user3 = new ApplicationUser
            {
                Name = game.Player3.Name, // "C",
                PlayerCards = new List<string[]>
                {
                    new string[]{"14", "Diamond"},
                    new string[]{"4", "Spade"},
                },
                Chips = 0
            };

            ApplicationUser user4 = new ApplicationUser
            {
                Name = game.Player4.Name, // "D",
                PlayerCards = new List<string[]>
                {
                    new string[]{"14", "Spade"},
                    new string[]{"3", "Heart"},
                },
                Chips = 0
            };

            room.Chair0 = user1;
            room.Chair2 = user2;
            room.Chair3 = user3;
            room.Chair4 = user4;

            room.PotOfChair0 = 25;
            room.PotOfChair2 = 50;
            room.PotOfChair3 = 100;
            room.PotOfChair4 = 100;

            var result = room.SpreadMoneyToWinners();
            var winner = result.Item1.FirstOrDefault().Winners.FirstOrDefault().Name; // TODO: Update this

            var player1HandRank = room.GetPlayerHandRank(user1);
            Console.WriteLine(player1HandRank);
            Console.WriteLine();
            var player2HandRank = room.GetPlayerHandRank(user2);
            Console.WriteLine(player2HandRank);
            Console.WriteLine();
            var player3HandRank = room.GetPlayerHandRank(user3);
            Console.WriteLine(player3HandRank);
            Console.WriteLine();
            var player4HandRank = room.GetPlayerHandRank(user4);
            Console.WriteLine(player4HandRank);
            Console.WriteLine();

            game.Player1.Rank = player1HandRank.Rank;
            game.Player1.RankName = player1HandRank.RankName;
            game.Player1.Winner = winner == game.Player1.Name;

            game.Player2.Rank = player2HandRank.Rank;
            game.Player2.RankName = player2HandRank.RankName;
            game.Player2.Winner = winner == game.Player2.Name;

            game.Player3.Rank = player3HandRank.Rank;
            game.Player3.RankName = player3HandRank.RankName;
            game.Player3.Winner = winner == game.Player3.Name;

            game.Player4.Rank = player4HandRank.Rank;
            game.Player4.RankName = player4HandRank.RankName;
            game.Player4.Winner = winner == game.Player4.Name;
        }

    }
}
