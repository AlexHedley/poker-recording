using Bunit;
using Poker.Components.Camera;

namespace Poker.WebApp.Tests.Components
{
    public class CameraTests : TestContext
    {
        public CameraTests() { }

        [Fact]
        public void CameraShows()
        {
            var cut = RenderComponent<CameraComponent>();
            string markup = "<h3>CameraComponent</h3>";
            cut.FindAll("h3")[0].MarkupMatches(markup);
        }
    }
}
