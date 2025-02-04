using Bunit;
using Poker.Shared.Pages;
using Index = Poker.Shared.Pages.Index;

namespace Poker.WebApp.Tests.Pages
{
    public class IndexTests : TestContext
    {
        public IndexTests() { }

        [Fact]
        public void Test1()
        {
            // arrange
            var ctx = new TestContext();

            // act
            var comp = ctx.RenderComponent<Index>();

            // assert
            string markup = "<h1>Poker ♣♦♥♠</h1>";
            comp.FindAll("h1")[0].MarkupMatches(markup);
        }
    }
}