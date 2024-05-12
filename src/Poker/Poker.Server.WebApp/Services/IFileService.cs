namespace Poker.Server.WebApp.Services
{
    public interface IFileService
    {
        public string FilePath { get; }
        public void SetupWatcher();
    }
}
