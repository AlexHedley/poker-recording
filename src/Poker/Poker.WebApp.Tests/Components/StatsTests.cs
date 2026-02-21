using Bunit;
using Poker.Components.Legacy.Stats;

namespace Poker.WebApp.Tests.Components
{
    public class StatsTests : BunitContext
    {
        public StatsTests() { }

        [Fact]
        public void StatsShow() 
        {
            var cut = Render<StatsComponent>();
            string markup = "<h3>StatsComponent</h3>";
            cut.FindAll("h3")[0].MarkupMatches(markup);

            string markup2 = "<p class=\"pot-odds\">#%</p>";
            cut.FindAll("p")[0].MarkupMatches(markup2);
        }
    }
}
