// 🃏 Texas holdem Rank Card Evaluator
// https://github.com/danielpaz6/Poker-Hand-Evaluator/tree/master/PokerHandEvaluator

namespace PokerHandEvaluator
{
    public class SidePot
    {
        public string Name { get; set; } // for example Main Pot, Side Pot 1, Side Pot 2 , ...
        public int PotAmount { get; set; }
        public int OriginalPotAmount { get; set; }
        public List<ApplicationUser> ContestedBy { get; set; }
        public List<ApplicationUser> Winners { get; set; }
        public string RankName { get; set; } // For example: Full House, Straight , High Card , ...
        public List<string[]> WinningCards { get; set; }

        public override string ToString()
        {
            var winningCards = string.Join(Environment.NewLine, WinningCards.Select(array => string.Join(" ", array)));
            var contestedByUsers = string.Join(",", ContestedBy);
            var winnersUsers = string.Join(",", Winners);
            return $"#SidePot#: Name:{Name} PotAmount:{PotAmount} OriginalPotAmount:{OriginalPotAmount} ContestedBy:{contestedByUsers} Winners:{winnersUsers} RankName:{RankName} WinningCards:{winningCards}";
        }
    }
}
