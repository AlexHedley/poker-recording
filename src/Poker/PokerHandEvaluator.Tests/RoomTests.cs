namespace PokerHandEvaluator.Tests
{
    public class RoomTests
    {
        public Room Room { get; set; }
        public ApplicationUser User1 { get; set; }
        public ApplicationUser User2 { get; set; }
        public ApplicationUser User3 { get; set; }
        public ApplicationUser User4 { get; set; }

        public RoomTests()
        {
            // Suits: club (♣), diamond (♦), heart (♥) and spade (♠).
            Room = new Room
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

            User1 = new ApplicationUser
            {
                Name = "A",
                PlayerCards = new List<string[]>
                {
                    new string[]{"8", "Club"},
                    new string[]{"7", "Heart"},
                },
                Chips = 0
            };

            User2 = new ApplicationUser
            {
                Name = "B",
                PlayerCards = new List<string[]>
                {
                    new string[]{"9", "Heart"},
                    new string[]{"5", "Heart"},
                },
                Chips = 0
            };

            User3 = new ApplicationUser
            {
                Name = "C",
                PlayerCards = new List<string[]>
                {
                    new string[]{"14", "Diamond"},
                    new string[]{"4", "Spade"},
                },
                Chips = 0
            };

            User4 = new ApplicationUser
            {
                Name = "D",
                PlayerCards = new List<string[]>
                {
                    new string[]{"14", "Spade"},
                    new string[]{"3", "Heart"},
                },
                Chips = 0
            };

            Room.Chair0 = User1;
            Room.Chair2 = User2;
            Room.Chair3 = User3;
            Room.Chair4 = User4;

            Room.PotOfChair0 = 25;
            Room.PotOfChair2 = 50;
            Room.PotOfChair3 = 100;
            Room.PotOfChair4 = 100;
        }
        
        [Fact]
        public void Test1()
        {
            // Arrange
            // Uses above Setup()

            // Act
            var result = Room.SpreadMoneyToWinners();

            // Assert
            //Console.WriteLine(Room.GetPlayerHandRank(User1));
            //Console.WriteLine();
            
            //# HandRank#: RankName:Flush Rank:500.8506977549489 Cards:13 Club
            //5 Club
            //8 Club
            //11 Club
            //13 Club
            //14 Club
            //User:#ApplicationUser#: Name:A Chips:100 Cards:8 Club
            //7 Heart IsPlayingThisRound:True IsPlayingThisGame:True WinningPrice:0

            var expectedUser1Result = new HandRank()
            {
                Cards = new List<string[]> { 
                    new string[] { "13", "Club" }, 
                    new string[] { "5", "Club" }, 
                    new string[] { "8", "Club" }, 
                    new string[] { "11", "Club" }, 
                    new string[] { "13", "Club" }, 
                    new string[] { "14", "Club" } 
                },
                Rank = 500.8506977549489,
                RankName = "Flush",
                User = User1,
                WinningPrice = 0
            };
            var actualUser1Result = Room.GetPlayerHandRank(User1);

            Assert.Equal(expectedUser1Result.Cards, actualUser1Result.Cards);
            Assert.Equal(expectedUser1Result.Rank, actualUser1Result.Rank);
            Assert.Equal(expectedUser1Result.RankName, actualUser1Result.RankName);
            Assert.Equal(expectedUser1Result.User, actualUser1Result.User);
            Assert.Equal(expectedUser1Result.WinningPrice, actualUser1Result.WinningPrice);

            //Console.WriteLine(Room.GetPlayerHandRank(User2));
            //Console.WriteLine();

            //#HandRank#: RankName:Pair Rank:261.59346189679195 Cards:5
            //5  User:#ApplicationUser#: Name:B Chips:0 Cards:9 Heart
            //5 Heart IsPlayingThisRound:True IsPlayingThisGame:True WinningPrice:0

            //Console.WriteLine(Room.GetPlayerHandRank(User3));
            //Console.WriteLine();

            //#HandRank#: RankName:Pair Rank:280.8132371443412 Cards:14
            //14  User:#ApplicationUser#: Name:C Chips:87 Cards:14 Diamond
            //4 Spade IsPlayingThisRound:True IsPlayingThisGame:True WinningPrice:0

            //Console.WriteLine(Room.GetPlayerHandRank(User4));
            //Console.WriteLine();

            //#HandRank#: RankName:Pair Rank:280.8132371443412 Cards:14
            //14  User:#ApplicationUser#: Name:D Chips:87 Cards:14 Spade
            //3 Heart IsPlayingThisRound:True IsPlayingThisGame:True WinningPrice:0
        }
    }
}