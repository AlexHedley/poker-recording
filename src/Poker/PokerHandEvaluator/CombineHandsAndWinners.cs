// 🃏 Texas holdem Rank Card Evaluator
// https://github.com/danielpaz6/Poker-Hand-Evaluator/tree/master/PokerHandEvaluator

namespace PokerHandEvaluator
{
    public class CombineHandsAndWinners
    {
        public List<List<HandRank>> totalWinners;
        public List<SidePot> potList;

        public CombineHandsAndWinners(List<List<HandRank>> totalWinners, List<SidePot> potList)
        {
            this.totalWinners = totalWinners;
            this.potList = potList;
        }
    }
}
