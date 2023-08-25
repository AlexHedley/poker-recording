using Microsoft.Extensions.Logging;

using NSubstitute;

using Poker.API.Controllers;

namespace Poker.API.Tests
{
    public class PokerControllerTest
    {
        [Fact]
        public void Version_ReturnsCurrentVersion()
        {
            // Arrange
            var mockLogger = Substitute.For<ILogger<PokerController>>();
            var controller = new PokerController(mockLogger);

            // Act
            var result = controller.GetVersion();

            // Assert
            var version = "0.0.1.0"; //Type.GetType("Poker.API").Assembly.GetName().Version.ToString();
            Assert.Equal(version, result);
        }
    }
}