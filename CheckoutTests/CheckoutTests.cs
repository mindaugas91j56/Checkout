using Xunit;
using Mindaugas.Jarmaliunas.Checkout;

namespace CheckoutTests
{
    public class CheckoutTests
    {
        [Fact]
        public void CheckoutTest_ItemA()
        {
            var superMarketStock = new SuperMarketStock();

            string itemCode = "A";

            Assert.Equal(50, superMarketStock.GetPrice_Old(itemCode));
        }

        [Fact]
        public void CheckoutTest_ItemB()
        {
            var superMarketStock = new SuperMarketStock();

            string itemCode = "B";

            Assert.Equal(30, superMarketStock.GetPrice_Old(itemCode));
        }

        [Fact]
        public void CheckoutTest_ItemC()
        {
            var superMarketStock = new SuperMarketStock();

            string itemCode = "C";

            Assert.Equal(20, superMarketStock.GetPrice_Old(itemCode));
        }

        [Fact]
        public void CheckoutTest_ItemD()
        {
            var superMarketStock = new SuperMarketStock();

            string itemCode = "D";

            Assert.Equal(15, superMarketStock.GetPrice_Old(itemCode));
        }

        [Fact]
        public void CheckoutTest_ScanProduct_MultipleA()
        {
            //Arrange
            var superMarketStock = new SuperMarketStock();
            superMarketStock.AddStock();
            superMarketStock.AddDeals();
            //Act
            superMarketStock.AddScannedItem("A");
            superMarketStock.AddScannedItem("A");
            superMarketStock.AddScannedItem("A");
            //Assert
            Assert.Equal(130, superMarketStock.calculateTotalPrice(superMarketStock.GetItemCodeList()));
        }

        [Fact]
        public void CheckoutTest_ScanProduct_MultipleB()
        {
            //Arrange
            var superMarketStock = new SuperMarketStock();
            superMarketStock.AddStock();
            superMarketStock.AddDeals();
            //Act
            superMarketStock.AddScannedItem("B");
            superMarketStock.AddScannedItem("B");
            //Assert
            Assert.Equal(45, superMarketStock.calculateTotalPrice(superMarketStock.GetItemCodeList()));
        }

        [Fact]
        public void CheckoutTest_ScanProduct_MultipleC()
        {
            //Arrange
            var superMarketStock = new SuperMarketStock();
            superMarketStock.AddStock();
            superMarketStock.AddDeals();
            //Act
            superMarketStock.AddScannedItem("C");
            superMarketStock.AddScannedItem("C");
            superMarketStock.AddScannedItem("C");
            superMarketStock.AddScannedItem("C");
            //Assert
            Assert.Equal(80, superMarketStock.calculateTotalPrice(superMarketStock.GetItemCodeList()));
        }

        [Fact]
        public void CheckoutTest_ScanProduct_MultipleD()
        {
            //Arrange
            var superMarketStock = new SuperMarketStock();
            superMarketStock.AddStock();
            superMarketStock.AddDeals();
            //Act
            superMarketStock.AddScannedItem("D");
            superMarketStock.AddScannedItem("D");
            superMarketStock.AddScannedItem("D");
            superMarketStock.AddScannedItem("D");
            //Assert
            Assert.Equal(60, superMarketStock.calculateTotalPrice(superMarketStock.GetItemCodeList()));
        }
    }
}
