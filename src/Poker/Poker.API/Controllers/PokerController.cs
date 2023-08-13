using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;

namespace Poker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokerController : ControllerBase
    {
        
        private readonly ILogger<PokerController> _logger;

        public PokerController(ILogger<PokerController> logger)
        {
            _logger = logger;
        }

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