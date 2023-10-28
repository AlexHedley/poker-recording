using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poker.API.Services;
using System.Diagnostics;
using System.Reflection;

namespace Poker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        #region Properties

        private readonly ILogger<PokerController> _logger;
        private readonly ICardService _cardService;
        //private readonly IConfigurationRoot _configurationRoot;
        //private string _path;

        #endregion Properties

        /// <summary>
        /// Card Controller
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="cardService"></param>
        public CardController(ILogger<PokerController> logger, ICardService cardService)
        {
            _logger = logger;
            _cardService = cardService;

            //_configurationRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            //_path = _configurationRoot["streaming:folder"];

            //Debug.Print(_path);
            //_logger.LogInformation(_path, DateTime.UtcNow.ToLongTimeString());
        }

        /// <summary>
        /// Update Card
        /// </summary>
        /// <param name="player">The Player number</param>
        /// <param name="text">The RFID value of the sticker</param>
        [HttpPut(Name = "Card")]
        public void UpdateCard(int player, /*int pos,*/ string text)
        {
            _cardService.UpdateCard(player, text);
        }

        /// <summary>
        /// Clear Table
        /// </summary>
        [HttpDelete(Name = "Card")]
        public void ClearTable()
        {
            _cardService.ClearCards(0); // Board
            _cardService.ClearCards(1); // P1, P2, P3, P4...
        }
    }
}
