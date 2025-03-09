using EShop.Application.Services;

namespace EShop.Application.Tests.Services
{
    public class CreditCardServiceTest
    {
        [Fact]
        public void ValidateCard_CheckCardToShortLength_ReturnFalse()
        {
            // Arrange
            var creditCardService = new CreditCardService();
            string cardNumber = "1212";

            // Act
            var result = creditCardService.ValidateCardNumber(cardNumber);

            // Assert
            Assert.False(result);
        }


        [Fact]
        public void ValidateCard_CheckCardCorrectLength_ReturnTrue()
        {
            // Arrange
            var creditCardService = new CreditCardService();
            string cardNumber = "349779658312797";

            // Act
            var result = creditCardService.ValidateCardNumber(cardNumber);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValidateCard_CheckCardToLongLength_ReturnFalse()
        {
            // Arrange
            var creditCardService = new CreditCardService();
            string cardNumber = "349779658312797349779658312797";

            // Act
            var result = creditCardService.ValidateCardNumber(cardNumber);

            // Assert
            Assert.False(result);
        }
    }
}
