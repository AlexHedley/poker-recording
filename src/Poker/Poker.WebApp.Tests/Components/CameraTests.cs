using Bunit;
using Poker.Components.Legacy.Camera;

namespace Poker.WebApp.Tests.Components
{
    public class CameraTests : BunitContext
    {
        public CameraTests() { }

        [Fact]
        public void CameraShows()
        {
            var cut = Render<CameraComponent>();
            string markup = "<h3>CameraComponent</h3>";
            cut.FindAll("h3")[0].MarkupMatches(markup);
        }
    }
}
