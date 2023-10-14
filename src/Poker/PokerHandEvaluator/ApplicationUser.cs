// 🃏 Texas holdem Rank Card Evaluator
// https://github.com/danielpaz6/Poker-Hand-Evaluator/tree/master/PokerHandEvaluator

namespace PokerHandEvaluator
{
    public class ApplicationUser
    {
        public string Name { get; set; }
        public int Chips { get; set; }
        public List<string[]> PlayerCards { get; set; }
        public bool IsPlayingThisRound { get; set; } = true;
        public bool IsPlayingThisGame { get; set; } = true;

        public override string ToString()
        {
            var cards = string.Join(Environment.NewLine, PlayerCards.Select(array => string.Join(" ", array)));
            return $"#ApplicationUser#: Name:{Name} Chips:{Chips} Cards:{cards} IsPlayingThisRound:{IsPlayingThisRound} IsPlayingThisGame:{IsPlayingThisGame}";
        }
    }
}
