using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;

using Poker.API.Services;

namespace Poker.API.Controllers
{
    /// <summary>
    /// Poker Controller
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class PokerController : ControllerBase
    {
        #region Properties
        
        private readonly ILogger<PokerController> _logger;
        private readonly ICardService _cardService;

        #endregion Properties

        /// <summary>
        /// Poker Controller
        /// </summary>
        /// <param name="logger"></param>
        public PokerController(ILogger<PokerController> logger, ICardService cardService)
        {
            _logger = logger;
            _cardService = cardService;
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

        /// <summary>
        /// Update Card
        /// </summary>
        /// <param name="player">The Player number</param>
        ///// <param name="pos">The card position</param>
        /// <param name="text">The RFID value of the sticker</param>
        [HttpPut(Name = "Card")]
        public void UpdateCard(int player, /*int pos,*/ string text)
        {
            _cardService.UpdateCard(player, text);
        }

        /// <summary>
        /// Clear Table
        /// </summary>
        [HttpDelete(Name = "Clear")]
        public void ClearTable()
        {
            _cardService.ClearCards(0); // Board
            _cardService.ClearCards(1); // P1, P2, P3, P4...
        }
    }
}