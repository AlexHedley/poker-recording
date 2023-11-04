namespace Poker.API
{
    public static class ApplicationSettings
    {
        public const string StreamingUrl = "Streaming";
        public static StreamingOptions StreamingOptions { get; set; } = new StreamingOptions();

    }

    public class StreamingOptions
    {
        public string Folder { get; set; }
        public string PlayersFolder { get; set; }
        public string CardFolder { get; set; }
    }
}
