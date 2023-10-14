using Microsoft.Extensions.Logging;

using NSubstitute;

using Poker.API.Services;

namespace Poker.API.Tests.Services
{
    public class CardServiceTests
    {
        //[Fact]
        public void UpdateCard()
        {
            // Arrange
            var mockLogger = Substitute.For<ILogger<CardService>>();
            var service = new CardService(mockLogger);
            var player = 1;
            var card = "3c"; //3♣

            // Act
            var result = service.UpdateCard(player, card);

            // Assert
            Assert.True(result);
        }

        //[Fact]
        public void ClearCards()
        {
            // Arrange
            var mockLogger = Substitute.For<ILogger<CardService>>();
            var service = new CardService(mockLogger);
            var player = 0;

            // Act
            service.ClearCards(player);

            // Assert
            //Assert.Equal(, );
        }
    }
}
