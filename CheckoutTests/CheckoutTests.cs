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
            superMarketsuperMarket.AddsuperMarket();
            superMarketsuperMarket.AddDeals();
            //Act
            superMarketsuperMarket.AddScannedItem("A");
            superMarketsuperMarket.AddScannedItem("A");
            superMarketsuperMarket.AddScannedItem("A");
            //Assert
            Assert.Equal(130, superMarketsuperMarket.calculateTotalPrice(superMarketsuperMarket.GetItemCodeList()));
        }

        [Fact]
        public void CheckoutTest_ScanProduct_MultipleB()
        {
            //Arrange
            var superMarketsuperMarket = new SuperMarketsuperMarket();
            superMarketsuperMarket.AddsuperMarket();
            superMarketsuperMarket.AddDeals();
            //Act
            superMarketsuperMarket.AddScannedItem("B");
            superMarketsuperMarket.AddScannedItem("B");
            //Assert
            Assert.Equal(45, superMarketsuperMarket.calculateTotalPrice(superMarketsuperMarket.GetItemCodeList()));
        }

        [Fact]
        public void CheckoutTest_ScanProduct_MultipleC()
        {
            //Arrange
            var superMarketsuperMarket = new SuperMarketsuperMarket();
            superMarketsuperMarket.AddsuperMarket();
            superMarketsuperMarket.AddDeals();
            //Act
            superMarketsuperMarket.AddScannedItem("C");
            superMarketsuperMarket.AddScannedItem("C");
            superMarketsuperMarket.AddScannedItem("C");
            superMarketsuperMarket.AddScannedItem("C");
            //Assert
            Assert.Equal(80, superMarketsuperMarket.calculateTotalPrice(superMarketsuperMarket.GetItemCodeList()));
        }

        [Fact]
        public void CheckoutTest_ScanProduct_MultipleD()
        {
            //Arrange
            var superMarketsuperMarket = new SuperMarketsuperMarket();
            superMarketsuperMarket.AddsuperMarket();
            superMarketsuperMarket.AddDeals();
            //Act
            superMarketsuperMarket.AddScannedItem("D");
            superMarketsuperMarket.AddScannedItem("D");
            superMarketsuperMarket.AddScannedItem("D");
            superMarketsuperMarket.AddScannedItem("D");
            //Assert
            Assert.Equal(60, superMarketsuperMarket.calculateTotalPrice(superMarketsuperMarket.GetItemCodeList()));
        }

        [Fact]
        public void CheckoutTest_ScanProduct_FullProductListWithMultiples()
        {
            //Arrange
            var superMarketsuperMarket = new SuperMarketsuperMarket();
            superMarketsuperMarket.AddsuperMarket();
            superMarketsuperMarket.AddDeals();
            //Act
            superMarketsuperMarket.AddScannedItem("A");
            superMarketsuperMarket.AddScannedItem("A");
            superMarketsuperMarket.AddScannedItem("A");
            superMarketsuperMarket.AddScannedItem("B");
            superMarketsuperMarket.AddScannedItem("B");
            superMarketsuperMarket.AddScannedItem("C");
            superMarketsuperMarket.AddScannedItem("D");
            //Assert
            Assert.Equal(210, superMarketsuperMarket.calculateTotalPrice(superMarketsuperMarket.GetItemCodeList()));
        }
    }
}
