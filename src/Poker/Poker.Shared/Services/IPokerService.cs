namespace Poker.Shared.Services
{
    public interface IPokerService
    {
        Task<string> GetVersionAsync();
        Task PutPlayerAndCardAsync(int player, string card);
        Task DeleteAsync();
    }
}
