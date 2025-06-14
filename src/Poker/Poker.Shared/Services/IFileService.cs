using Poker.Common.Models;

namespace Poker.Shared.Services
{
    public delegate void Notify(); // delegate

    public interface IFileService
    {
        public string FilePath { get; }
        public Stats Stats { get; }

        public void SetupWatcher();
        public void UpdateStats();

        public event Notify ProcessCompleted; // event
    }
}
