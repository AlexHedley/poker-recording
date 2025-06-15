namespace Poker.Common.Models
{
    public class Game
    {
        public Player Player1 { get; set; } = new Player();
        public Player Player2 { get; set; } = new Player();
        public Player Player3 { get; set; } = new Player();
        public Player Player4 { get; set; } = new Player();
        public Board Board { get; set; } = new Board();
    }
}
