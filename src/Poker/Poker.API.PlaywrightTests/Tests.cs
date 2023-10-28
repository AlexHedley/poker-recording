using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.API.PlaywrightTests
{
    internal class Tests : PageTest
    {
        public static string webAppUrl;

        [OneTimeSetUp]
        public void Init()
        {
            webAppUrl = TestContext.Parameters["WebAppUrl"]
                    ?? throw new Exception("WebAppUrl is not configured as a parameter.");
        }
    }
}
