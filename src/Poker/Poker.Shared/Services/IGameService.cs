using Poker.Common.Models;

namespace Poker.Shared.Services
{
    public interface IGameService
    {
        public Game game { get; set; }
        void InitializeGame();
    }
}
