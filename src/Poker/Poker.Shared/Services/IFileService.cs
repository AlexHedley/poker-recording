namespace Poker.Shared.Services
{
    public interface IFileService
    {
        public string FilePath { get; }
        public void SetupWatcher();
    }
}
