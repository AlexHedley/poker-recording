namespace Poker.API.Services
{
    /// <summary>
    /// CardService - Interface
    /// </summary>
    public interface ICardService
    {
        /// <summary>
        /// Update Card
        /// </summary>
        /// <param name="player"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        bool UpdateCard(int player, string text);

        /// <summary>
        /// Clear Cards
        /// </summary>
        /// <param name="player"></param>
        void ClearCards(int player);

        /// <summary>
        /// Clear Stats
        /// </summary>
        /// <param name="player"></param>
        void ClearStats(int player);
    }
}
