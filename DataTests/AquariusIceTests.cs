using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Treats;

namespace GyroScope.DataTests
{
    public class AquariusIceTests
    {
        [Fact]
        public void FlavorShouldDefaultToLemon()
        {
            var ice = new AquariusIce();
            Assert.Equal(AquariusIceFlavor.Lemon, ice.Flavor);
        }

        [Theory]
        [InlineData(AquariusIceFlavor.BlueRaspberry)]
        [InlineData(AquariusIceFlavor.Lemon)]
        [InlineData(AquariusIceFlavor.Mango)]
        [InlineData(AquariusIceFlavor.Orange)]
        [InlineData(AquariusIceFlavor.Strawberry)]
        [InlineData(AquariusIceFlavor.Watermellon)]
        public void ShouldBeAbleToSetFlavor(AquariusIceFlavor flavor)
        {
            var ice = new AquariusIce();
            ice.Flavor = flavor;
            Assert.Equal(flavor, ice.Flavor);
        }

        [Fact]
        public void ShouldDefaultToSmall()
        {
            var ice = new AquariusIce();
            Assert.Equal(Size.Small, ice.Size);
        }

        [Theory]
        [InlineData(Size.Small, 2.0)]
        [InlineData(Size.Medium, 2.5)]
        [InlineData(Size.Large, 3.0)]
        public void ShouldHaveTheRightPriceForSize(Size size, decimal price)
        {
            var ice = new AquariusIce()
            {
                Size = size
            };
            Assert.Equal(price, ice.Price);

        }

    }
}
