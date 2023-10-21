namespace Poker.API.Services
{
    /// <summary>
    /// Card Service
    /// </summary>
    public class CardService: ICardService
    {
        #region Properties

        private readonly ILogger<CardService> _logger;
        private readonly IConfigurationRoot _configurationRoot;
        private string _path;

        private string _playersPath;
        private string _cardsPath;

        #endregion Properties

        /// <summary>
        /// Card Service
        /// </summary>
        /// <param name="logger"></param>
        /// <exception cref="DirectoryNotFoundException"></exception>
        public CardService(ILogger<CardService> logger)
        {
            _logger = logger;

            _configurationRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _path = _configurationRoot["streaming:folder"];

            var playersFolder = _configurationRoot["streaming:playersFolder"];
            var cardFolder = _configurationRoot["streaming:cardFolder"];

            var _playersPath = Path.Combine(new string[] { _path, playersFolder });
            var _cardsPath = Path.Combine(new string[] { _path, cardFolder });

            if (!Directory.Exists(_playersPath)) throw new DirectoryNotFoundException();
            if (!Directory.Exists(_cardsPath)) throw new DirectoryNotFoundException();
        }

        /// <inheritdoc />
        public bool UpdateCard(int player, /*int pos,*/ string text)
        {
            // Player x needs card 1 updating to x
            // Player x needs card 2 updating to y
            // Board needs card (flop 1, 2, 3) (turn) (river) updating to z

            var fileExt = ".webp";

            var mappings = Helper.Mappings();

            // Players => Player{#}.txt

            var card = mappings.FirstOrDefault(c => c.CardHex == text);
            if (card is null)
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
                        fileName = CalculateBoardCard();
                        break;
                    default:
                        fileName = CalculatePlayerCard(player); // $"P{player}C0.png";
                        break;
                }

                _logger.LogDebug($"Card: '{card.CardName}', '{card.ImageName}', '{card.CardHex}', '{card.CardHex}'.");
                var cardToSwap = Path.Combine(new string[] { _cardsPath, $"{card.ImageName}{fileExt}" }); // sj.webp

                try
                {
                    // D:\Twitch\Scenes\Poker\Cards\sj.webp => D:\Twitch\Scenes\Poker\players\P1C1.png
                    File.Copy(cardToSwap, Path.Combine(_playersPath, fileName));
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                }                
            }

            return true;
        }

        /// <inheritdoc />
        public void ClearCards(int player)
        {
            var cleared = false;
            switch (player)
            {
                case 0: // Board
                    cleared = ClearBoardCards();
                    break;
                default:
                    cleared = ClearPlayerCards(player);
                    break;
            }
            _logger.LogDebug($"Cleared cards for Player '{player}': '{cleared}'.");
        }

        #region Private

        /// <summary>
        /// Clear Board Cards
        /// </summary>
        /// <returns></returns>
        private bool ClearBoardCards()
        {
            var cleared = new List<bool>();
            var cards = new string[] { Constants.BoardFlopOne, Constants.BoardFlopTwo, Constants.BoardFlopThree, Constants.BoardTurn, Constants.BoardRiver };
            
            foreach( var card in cards)
            {
                var cardPath = Path.Combine(_playersPath, card);
                var clear = ClearCard(cardPath);
                cleared.Add(clear);
            }
            
            return cleared.All(x => x);
        }

        /// <summary>
        /// Clear Player Cards
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        private bool ClearPlayerCards(int player)
        {
            var cleared = new List<bool>();
            var cards = new string[] { $"P{player}C1.png", $"P{player}C2.png" };

            foreach (var card in cards)
            {
                var cardPath = Path.Combine(_playersPath, card);
                var clear = ClearCard(cardPath);
                cleared.Add(clear);
            }

            return cleared.All(x => x);
        }

        /// <summary>
        /// Clear Card
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        private bool ClearCard(string file)
        {
            try
            {
                File.Delete(file);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Calculate Player Card
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        private string CalculatePlayerCard(int player)
        {
            // P1C1.png or P1C2.png
            // Check if card 1 exists, if it does, it's already set so check for card 2.
            var fileName = $"P{player}C1.png";

            var cardPath = Path.Combine(_playersPath, fileName);

            if (File.Exists(cardPath))
            {
                cardPath = Path.Combine(_playersPath, $"P{player}C2.png");
                if (File.Exists(cardPath))
                {
                    // Already set.
                }
                fileName = $"P{player}C2.png";
            }

            return fileName;
        }

        /// <summary>
        /// Calculate Board Card
        /// </summary>
        /// <returns></returns>
        private string CalculateBoardCard()
        {
            var cards = new string[] { Constants.BoardFlopOne, Constants.BoardFlopTwo, Constants.BoardFlopThree, Constants.BoardTurn, Constants.BoardRiver };

            foreach (var card in cards)
            {
                var cardPath = Path.Combine(_playersPath, card);
                if (!File.Exists(cardPath))
                {
                    return card;
                }
            }
            return string.Empty; // TODO: ...
        }

        #endregion Private
    }
}
