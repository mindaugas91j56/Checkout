using Xunit;
using Mindaugas.Jarmaliunas.Checkout;

namespace CheckoutTests
{
    public class CheckoutTests
    {
    
        [Fact]
        public void CheckoutTest_ScanProduct_MultipleA()
        {
            //Arrange
            var superMarketsuperMarket = new SuperMarketsuperMarket();
            superMarketsuperMarket.GenerateSuperMarketItems();
            //Act
            superMarketsuperMarket.Scan("A");
            superMarketsuperMarket.Scan("A");
            superMarketsuperMarket.Scan("A");
            //Assert
            Assert.Equal(130, superMarketsuperMarket.GetTotalPrice());
        }

        [Fact]
        public void CheckoutTest_ScanProduct_MultipleB()
        {
            //Arrange
            var superMarketsuperMarket = new SuperMarketsuperMarket();
            superMarketsuperMarket.GenerateSuperMarketItems();
            //Act
            superMarketsuperMarket.Scan("B");
            superMarketsuperMarket.Scan("B");
            //Assert
            Assert.Equal(45, superMarketsuperMarket.GetTotalPrice());
        }

        [Fact]
        public void CheckoutTest_ScanProduct_MultipleC()
        {
            //Arrange
            var superMarketsuperMarket = new SuperMarketsuperMarket();
            superMarketsuperMarket.GenerateSuperMarketItems();
            //Act
            superMarketsuperMarket.Scan("C");
            superMarketsuperMarket.Scan("C");
            superMarketsuperMarket.Scan("C");
            superMarketsuperMarket.Scan("C");
            //Assert
            Assert.Equal(80, superMarketsuperMarket.GetTotalPrice());
        }

        [Fact]
        public void CheckoutTest_ScanProduct_MultipleD()
        {
            //Arrange
            var superMarketsuperMarket = new SuperMarketsuperMarket();
            superMarketsuperMarket.GenerateSuperMarketItems();
            //Act
            superMarketsuperMarket.Scan("D");
            superMarketsuperMarket.Scan("D");
            superMarketsuperMarket.Scan("D");
            superMarketsuperMarket.Scan("D");
            //Assert
            Assert.Equal(60, superMarketsuperMarket.GetTotalPrice());
        }

        [Fact]
        public void CheckoutTest_ScanProduct_FullProductListWithMultiples()
        {
            //Arrange
            var superMarketsuperMarket = new SuperMarketsuperMarket();
            superMarketsuperMarket.GenerateSuperMarketItems();
            //Act
            superMarketsuperMarket.Scan("A");
            superMarketsuperMarket.Scan("A");
            superMarketsuperMarket.Scan("A");
            superMarketsuperMarket.Scan("B");
            superMarketsuperMarket.Scan("B");
            superMarketsuperMarket.Scan("C");
            superMarketsuperMarket.Scan("D");
            //Assert
            Assert.Equal(210, superMarketsuperMarket.GetTotalPrice());
        }
    }
}
