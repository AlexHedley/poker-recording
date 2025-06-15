using System;
using System.Collections.Generic;
using System.Linq;
namespace Poker.Common.Models
{
    public class Board
    {
        public string? FlopOne { get; set; }
        public string? FlopTwo { get; set; }
        public string? FlopThree { get; set; }
        public string? Turn { get; set; }
        public string? River { get; set; }

        public string CameraUrl { get; set; }

        public string Pot { get; set; }
        public string SmallBlind { get; set; }
        public string BigBlind { get; set; }
        public string Ante { get; set; }
    }
}
