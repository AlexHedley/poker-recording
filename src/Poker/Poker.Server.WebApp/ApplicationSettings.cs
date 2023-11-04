namespace Poker.Server.WebApp
{
    public static class ApplicationSettings
    {
        public const string StreamingUrl = "Streaming";
        public static StreamingOptions StreamingOptions { get; set; } = new StreamingOptions();

        public const string CamerasUrl = "Cameras";
        public static CameraOptions CameraOptions { get; set; } = new CameraOptions();
    }

    public class StreamingOptions
    {
        public string Folder { get; set; }
        public string PlayersFolder { get; set; }
        public string CardFolder { get; set; }
    }

    public class CameraOptions
    {
        public string One { get; set; }
        public string Two { get; set; }
        public string Three { get; set; }
        public string Four { get; set; }
        public string Five { get; set; }
    }
}
