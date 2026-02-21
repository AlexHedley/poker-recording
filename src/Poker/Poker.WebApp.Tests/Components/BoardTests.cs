using Bunit;
using Poker.Components.Legacy.Board;

namespace Poker.WebApp.Tests.Components
{
    public class BoardTests : BunitContext
    {
        public BoardTests() { }

        [Fact]
        public void BoardShows()
        {
            var cut = Render<BoardComponent>();
            string markup = "<h3>BoardComponent</h3>";
            cut.FindAll("h3")[0].MarkupMatches(markup);

            string markup2 = "<p>C1 | C2 | C3 | C4 | C5</p>";
            cut.FindAll("p")[0].MarkupMatches(markup2);
        }
    }
}
