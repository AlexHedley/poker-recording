using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace Poker.API.PlaywrightTests
{
    [TestFixture]
    public class PokerTest : PlaywrightTest
    {
        private IAPIRequestContext Request = null;

        [SetUp]
        public async Task SetUpAPITesting()
        {
            await CreateAPIRequestContext();
        }

        private async Task CreateAPIRequestContext()
        {
            Request = await this.Playwright.APIRequest.NewContextAsync(new()
            {
                BaseURL = "http://localhost:5174/api",
            });
        }

        [Test]
        public async Task UpdateCard()
        {
            await Request.PutAsync("/Poker?player=1&text=04 13 16 3D B9 2A 81");

            Assert.AreEqual(true, true);
        }

        [TearDown]
        public async Task TearDownAPITesting()
        {
            await Request.DisposeAsync();
        }
    }
}