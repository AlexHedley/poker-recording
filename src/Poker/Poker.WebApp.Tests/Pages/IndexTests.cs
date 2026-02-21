using Bunit;
using Poker.Shared.Pages;
using Index = Poker.Shared.Pages.Index;

namespace Poker.WebApp.Tests.Pages
{
    public class IndexTests : BunitContext
    {
        public IndexTests() { }

        [Fact]
        public void Test1()
        {
            // arrange
            var ctx = new BunitContext();

            // act
            var comp = ctx.Render<Index>();

            // assert
            string markup = "<h1>Poker ♣♦♥♠</h1>";
            comp.FindAll("h1")[0].MarkupMatches(markup);
        }
    }
}