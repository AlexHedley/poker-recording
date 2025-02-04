using Bunit;
using Poker.Components.PlayerComponent;

namespace Poker.WebApp.Tests.Components
{
    public class PlayerTests : TestContext
    {
        public PlayerTests() { }

        [Fact]
        public void PlayerShows()
        {
            var cut = RenderComponent<PlayerComponent>();
            string markup = "<h3>PlayerComponent</h3>";
            cut.FindAll("h3")[0].MarkupMatches(markup);

            // Camera
            // Cards
            // Stats
        }
    }
}
