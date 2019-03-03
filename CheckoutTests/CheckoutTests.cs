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

            Assert.Equal(50, superMarketStock.GetPrice(itemCode));
        }

        [Fact]
        public void CheckoutTest_ItemB()
        {
            var superMarketStock = new SuperMarketStock();

            string itemCode = "B";

            Assert.Equal(30, superMarketStock.GetPrice(itemCode));
        }

        [Fact]
        public void CheckoutTest_ItemC()
        {
            var superMarketStock = new SuperMarketStock();

            string itemCode = "C";

            Assert.Equal(20, superMarketStock.GetPrice(itemCode));
        }

        [Fact]
        public void CheckoutTest_ItemD()
        {
            var superMarketStock = new SuperMarketStock();

            string itemCode = "D";

            Assert.Equal(15, superMarketStock.GetPrice(itemCode));
        }

    }
}
