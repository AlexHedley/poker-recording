// 🃏 Texas holdem Rank Card Evaluator
// https://github.com/danielpaz6/Poker-Hand-Evaluator/tree/master/PokerHandEvaluator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
