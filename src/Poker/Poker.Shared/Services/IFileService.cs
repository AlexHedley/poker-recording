using Poker.Common.Models;

namespace Poker.Shared.Services
{
    public interface IFileService
    {
        public string FilePath { get; }
        public Stats Stats { get; }

        public void SetupWatcher();
        public void UpdateStats();
    }
}
