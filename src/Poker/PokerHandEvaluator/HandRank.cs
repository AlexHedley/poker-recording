// 🃏 Texas holdem Rank Card Evaluator
// https://github.com/danielpaz6/Poker-Hand-Evaluator/tree/master/PokerHandEvaluator

namespace PokerHandEvaluator
{
    public class HandRank
    {
        public string RankName { get; set; }
        public double Rank { get; set; }
        public List<string[]> Cards { get; set; }
        public ApplicationUser User { get; set; }
        public int WinningPrice { get; set; }

        public override string ToString()
        {
            var cards = string.Join(Environment.NewLine, Cards.Select(array => string.Join(" ", array)));
            return $"#HandRank#: RankName:{RankName} Rank:{Rank} Cards:{cards} User:{User} WinningPrice:{WinningPrice}";
        }
    }
}
