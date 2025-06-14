namespace Poker.Common.Models
{
    public class Stats
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }
        public string Player3 { get; set; }
        public string Player4 { get; set; }

        public string Player1PotOdds { get; set; }
        public string Player2PotOdds { get; set; }
        public string Player3PotOdds { get; set; }
        public string Player4PotOdds { get; set; }

        public string Player1Card1 { get; set; } = $"P1C1.png";
        public string Player1Card2 { get; set; } = $"P1C2.png";
        public string Player2Card1 { get; set; } = $"P2C1.png";
        public string Player2Card2 { get; set; } = $"P2C2.png";
        public string Player3Card1 { get; set; } = $"P3C1.png";
        public string Player3Card2 { get; set; } = $"P3C2.png";
        public string Player4Card1 { get; set; } = $"P4C1.png";
        public string Player4Card2 { get; set; } = $"P4C2.png";

        public string BoardFlopOne { get; set; } = Constants.BoardFlopOne;
        public string BoardFlopTwo { get; set; } = Constants.BoardFlopTwo;
        public string BoardFlopThree { get; set; } = Constants.BoardFlopThree;
        public string BoardTurn { get; set; } = Constants.BoardTurn;
        public string BoardRiver { get; set; } = Constants.BoardRiver;

        public string Player1Camera { get; set; }
        public string Player2Camera { get; set; }
        public string Player3Camera { get; set; }
        public string Player4Camera { get; set; }
        public string BoardCamera { get; set; }

        public Stats() { }

    }
}
