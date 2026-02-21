using Bunit;
using Poker.Components.Legacy.Cards;

namespace Poker.WebApp.Tests.Components
{
    public class CardsTests : BunitContext
    {
        public CardsTests() { }

        //[Fact]
        public void CardsShow()
        {
            var cut = Render<CardsComponent>();
            string markup = "<h3>CardsComponent</h3>";
            cut.FindAll("h3")[0].MarkupMatches(markup);

            string markup2 = "<p>C1 | C2</p>";
            cut.FindAll("p")[0].MarkupMatches(markup2);
        }
    }
}
