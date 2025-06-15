namespace Poker.Common.Models
{
    public class Player
    {
        public long Id { get; set; }

        public string? Name { get; set; }

        public string? Picture { get; set; }

        public string? Flag { get; set; }

        public string? Card1 { get; set; }

        public string? Card2 { get; set; }

        public string? PotOdds { get; set; }

        public string? Move { get; set; }

        public string? Unknown { get; set;}

        public string? Chips { get; set; }

        public string? Info { get; set; }

        public string CameraUrl { get; set; }

        public bool IsDealer { get; set; } = false;
        public bool IsSmallBlind { get; set; } = false;
        public bool IsBigBlind { get; set; } = false;

        // PokerHandEvaluator - HandRank
        public string RankName { get; set; }
        public double Rank { get; set; }
        public bool Winner { get; set; }
    }
}
