using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using PokerHandEvaluator;

// 🃏 Texas holdem Rank Card Evaluator
// https://github.com/danielpaz6/Poker-Hand-Evaluator/tree/master/PokerHandEvaluator

namespace Poker.Components.Models
{
    public class ResultViewModel
    {
        public Room Room { get; set; }
        public List<ApplicationUser> Users { get; set; }
        public List<SidePot> SidePots { get; set; }
        public List<List<HandRank>> TotalWinners { get; set; }

        public Tuple<HandRank, int> FindUserSidePot(ApplicationUser user)
        {
            for(int i = 0; i < TotalWinners.Count(); i++)
            {
                for(int j = 0; j < TotalWinners[i].Count(); j++)
                {
                    if (TotalWinners[i][j].User == user)
                        return new Tuple<HandRank, int>(TotalWinners[i][j], i+1);
                }
            }

            return null;
        }
    }
}