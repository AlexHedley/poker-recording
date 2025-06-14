using Poker.Common.Models;

namespace Poker.Server.WebApp
{
    public static class ApplicationSettings
    {
        public const string StreamingUrl = "Streaming";
        public static StreamingOptions StreamingOptions { get; set; } = new StreamingOptions();

        public const string CamerasUrl = "Cameras";
        public static CameraOptions CameraOptions { get; set; } = new CameraOptions();
    }
}
