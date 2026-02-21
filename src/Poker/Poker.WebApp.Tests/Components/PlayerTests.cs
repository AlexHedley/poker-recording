using Bunit;
using Poker.Components.Legacy.PlayerComponent;

namespace Poker.WebApp.Tests.Components
{
    public class PlayerTests : BunitContext
    {
        public PlayerTests() { }

        [Fact]
        public void PlayerShows()
        {
            var cut = Render<PlayerComponent>();
            string markup = "<h3>PlayerComponent</h3>";
            cut.FindAll("h3")[0].MarkupMatches(markup);

            // Camera
            // Cards
            // Stats
        }
    }
}
