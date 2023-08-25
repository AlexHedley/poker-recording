using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;

namespace Poker.API.Controllers
{
    /// <summary>
    /// Poker Controller
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PokerController : ControllerBase
    {
        private readonly ILogger<PokerController> _logger;
        private IConfigurationRoot configurationRoot;
        private string path;

        /// <summary>
        /// Poker Controller
        /// </summary>
        /// <param name="logger"></param>
        public PokerController(ILogger<PokerController> logger)
        {
            _logger = logger;

            configurationRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            path = configurationRoot["streaming:folder"];
            
            Debug.Print(path);
            _logger.LogInformation(path, DateTime.UtcNow.ToLongTimeString());
        }

        /// <summary>
        /// Get Version
        /// </summary>
        /// <returns>The current API Assembly version</returns>
        [HttpGet(Name = "Version")]
        public string GetVersion()
        {
            string assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            //string assemblyVersion = Assembly.LoadFile("your assembly file").GetName().Version.ToString();
            string fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
            string productVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
            return assemblyVersion;
        }

        // Player x needs card 1 updating to x
        // Player x needs card 2 updating to y
        // Board needs card (flop 1, 2, 3) (turn) (river) updating to z

        /// <summary>
        /// Update Card
        /// </summary>
        /// <param name="player">The Player number</param>
        ///// <param name="pos">The card position</param>
        /// <param name="text">The RFID value of the sticker</param>
        [HttpPut(Name = "Card")]
        void UpdateCard(int player, /*int pos,*/ string text)
        {
            var playersFolder = configurationRoot["streaming:playersFolder"];
            var cardFolder = configurationRoot["streaming:cardFolder"];

            var fullPlayersPath = Path.Combine(new string[] { path, playersFolder });
            var fullCardsPath = Path.Combine(new string[] { path, cardFolder });

            var fileExt = ".webp";

            var mappings = Mappings();

            // Players => Player{#}.txt

            var card = mappings.FirstOrDefault(c => c.Key == text);
            if ((card.Key, card.Value) == default)
            {
                _logger.LogInformation($"No card found for '{text}'");
            }
            else
            {
                // Create the filename
                var fileName = string.Empty;

                // Player Number | Card Number
                //P1C1.png
                // Board | Flop {1,2,3} | Turn | River
                //BoardFlop1.png

                switch (player)
                {
                    case 0: // Board
                        break;
                    default:
                        fileName = $"P{player}C0.png";
                        break;
                }

                var cardToSwap = Path.Combine(new string[] { fullCardsPath, $"{card.Value}{fileExt}" }); // sj.webp

                // D:\Twitch\Scenes\Poker\Cards\sj.webp => D:\Twitch\Scenes\Poker\players\P1C1.png
                System.IO.File.Copy(cardToSwap, Path.Combine(fullPlayersPath, fileName));

                //if (player == 0) // Board
                //{
                //    switch (pos)
                //    {
                //        case 1:
                //            fileName = "BoardFlop";
                //            break;
                //        case 2:
                //            break;
                //        case 3:
                //            break;
                //        default:
                //            break;
                //    }

                //}
            }
        }

        private List<KeyValuePair<string, string>> Mappings()
        {
            // Mappings
            // k2.webp => Clubs
            // l2.webp => Diamonds
            // p2.webp => Spades
            // s2.webp => Hearts

            List<KeyValuePair<string, string>> rfidMapping = new List<KeyValuePair<string, string>>
            {
                // Clubs (k)
                new KeyValuePair<string, string>("", "k2"), // 2 of Clubs
                new KeyValuePair<string, string>("", "k3"), // 3 of Clubs
                new KeyValuePair<string, string>("", "k4"), // 4 of Clubs
                new KeyValuePair<string, string>("", "k5"), // 5 of Clubs
                new KeyValuePair<string, string>("", "k6"), // 6 of Clubs
                new KeyValuePair<string, string>("", "k7"), // 7 of Clubs
                new KeyValuePair<string, string>("", "k8"), // 8 of Clubs
                new KeyValuePair<string, string>("", "k9"), // 9 of Clubs
                new KeyValuePair<string, string>("", "k4"), // 10 of Clubs
                new KeyValuePair<string, string>("", "kj"), // Jack of Clubs
                new KeyValuePair<string, string>("", "kq"), // Queen of Clubs
                new KeyValuePair<string, string>("", "kk"), // King of Clubs
                new KeyValuePair<string, string>("", "ka"), // Ace of Clubs

                // Diamonds (l)
                new KeyValuePair<string, string>("", "l2"), // 2 of Diamonds
                new KeyValuePair<string, string>("", "l3"), // 3 of Diamonds
                new KeyValuePair<string, string>("", "l4"), // 4 of Diamonds
                new KeyValuePair<string, string>("", "l5"), // 5 of Diamonds
                new KeyValuePair<string, string>("", "l6"), // 6 of Diamonds
                new KeyValuePair<string, string>("", "l7"), // 7 of Diamonds
                new KeyValuePair<string, string>("", "l8"), // 8 of Diamonds
                new KeyValuePair<string, string>("", "l9"), // 9 of Diamonds
                new KeyValuePair<string, string>("", "l4"), // 10 of Diamonds
                new KeyValuePair<string, string>("", "lj"), // Jack of Diamonds
                new KeyValuePair<string, string>("", "lq"), // Queen of Diamonds
                new KeyValuePair<string, string>("", "lk"), // King of Diamonds
                new KeyValuePair<string, string>("", "la"), // Ace of Diamonds

                // Spades (p)
                new KeyValuePair<string, string>("", "p2"), // 2 of Spades
                new KeyValuePair<string, string>("", "p3"), // 3 of Spades
                new KeyValuePair<string, string>("", "p4"), // 4 of Spades
                new KeyValuePair<string, string>("", "p5"), // 5 of Spades
                new KeyValuePair<string, string>("", "p6"), // 6 of Spades
                new KeyValuePair<string, string>("", "p7"), // 7 of Spades
                new KeyValuePair<string, string>("", "p8"), // 8 of Spades
                new KeyValuePair<string, string>("", "p9"), // 9 of Spades
                new KeyValuePair<string, string>("", "p4"), // 10 of Spades
                new KeyValuePair<string, string>("", "pj"), // Jack of Spades
                new KeyValuePair<string, string>("", "pq"), // Queen of Spades
                new KeyValuePair<string, string>("", "pk"), // King of Spades
                new KeyValuePair<string, string>("", "pa"), // Ace of Spades

                // Hearts (s)
                new KeyValuePair<string, string>("", "s2"), // 2 of Hearts
                new KeyValuePair<string, string>("", "s3"), // 3 of Hearts
                new KeyValuePair<string, string>("", "s4"), // 4 of Hearts
                new KeyValuePair<string, string>("", "s5"), // 5 of Hearts
                new KeyValuePair<string, string>("", "s6"), // 6 of Hearts
                new KeyValuePair<string, string>("", "s7"), // 7 of Hearts
                new KeyValuePair<string, string>("", "s8"), // 8 of Hearts
                new KeyValuePair<string, string>("", "s9"), // 9 of Hearts
                new KeyValuePair<string, string>("", "s4"), // 10 of Hearts
                new KeyValuePair<string, string>("", "sj"), // Jack of Hearts
                new KeyValuePair<string, string>("", "sq"), // Queen of Hearts
                new KeyValuePair<string, string>("", "sk"), // King of Hearts
                new KeyValuePair<string, string>("", "sa") // Ace of Hearts
            };

            return rfidMapping;
        }
    }
}