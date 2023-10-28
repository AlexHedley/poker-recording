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
        #region Properties
        
        private readonly ILogger<PokerController> _logger;
        private readonly IConfigurationRoot _configurationRoot;
        private string _path;

        #endregion Properties

        /// <summary>
        /// Poker Controller
        /// </summary>
        /// <param name="logger"></param>
        public PokerController(ILogger<PokerController> logger)
        {
            _logger = logger;
            _configurationRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _path = _configurationRoot["streaming:folder"];
            
            Debug.Print(_path);
            _logger.LogInformation(_path, DateTime.UtcNow.ToLongTimeString());
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

    }
}