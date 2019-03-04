using System.Collections.Generic;
using System.Linq;

namespace Mindaugas.Jarmaliunas.Checkout
{
    public class SuperMarketStock
    {
        private List<Products> product = new List<Products>();
        private List<Deals> deals = new List<Deals>();
        private List<string> barcodes = new List<string>();

        public int GetPrice_Old(string barcode)
        {
            if (barcode == "A")
            {
                return 50;
            }
            else if (barcode == "B")
            {
                return 30;
            }
            else if (barcode == "C")
            {
                return 20;
            }
            else if (barcode == "D")
            {
                return 15;
            }
            return 0;
        }
    

    public int GetPrice(string barcode)
        {
            var item = this.product.Find(x => x.productName == barcode).price;
            return item;
        }

        public bool DoesProductExist(string barcode)
        {
            return (this.product.Where(x => x.productName == barcode).FirstOrDefault()) != null ? true : false;
        }

        public int GetMultiBuyPrice(string barcode)
        {
            var item = this.deals.Find(x => x.productName == barcode).multiBuyPrice;
            return item;
        }

        public int GetMultiBuyQuantity(string barcode)
        {
            var item = this.deals.Find(x => x.productName == barcode).multiBuyPrice;
            return item;
        }

        public bool DoesProductHaveMultiBuyOption(string barcode)
        {
            return (this.deals.Where(x => x.productName == barcode).FirstOrDefault()) != null ? true : false;
        }

        public void AddScannedItem(string itemCode)
        {
            barcodes.Add(itemCode);
        }

        public List<string> GetItemCodeList()
        {
            return barcodes;

        }

        public int calculateTotalPrice(List<string> ItemList)
        {
            var totalPrice = 0;
            int multiBuy = 0;
            int total = 0;

            for (int i = 0; i < ItemList.Count; i++)
            {
                if (ItemList[i] != "A" && ItemList[i] != "B")
                {
                    total += GetPrice(ItemList[i]);
                }
            }

            var itemCodeBelongsToMultiBuy = ItemList.Contains("A");
            int numberOfItemsA = ItemList.Where(x => x.Contains("A")).Count();

            if (numberOfItemsA >= 3)
            {
                int pairsOfMultiples = numberOfItemsA % 3;
                multiBuy = GetMultiBuyPrice("A") * (numberOfItemsA / 3);

                multiBuy += GetPrice("A") * pairsOfMultiples;
                totalPrice += multiBuy;

            }
            else if (ItemList.Contains("A"))
            {
                totalPrice += numberOfItemsA * GetPrice("A");
            }

            var itemCodeBelongsToMultiBuyTwo = ItemList.Contains("B");
            int numberOfItemsB = ItemList.Where(x => x.Contains("B")).Count();


            if (numberOfItemsB >= 2)
            {
                int pairsOfMultiples = numberOfItemsB % 2;
                multiBuy = GetMultiBuyPrice("B") * (numberOfItemsB / 2);

                multiBuy += GetPrice("B") * pairsOfMultiples;
                totalPrice += multiBuy;

            }
            else if (ItemList.Contains("B"))
            {
                totalPrice += numberOfItemsB * GetPrice("B");
            }

            return totalPrice + total;
        }


        public SuperMarketStock AddStock()
        {
            product.Add(new Products
            {
                productName = "A",
                price = 50
            });

            product.Add(new Products
            {
                productName = "B",
                price = 30
            });

            product.Add(new Products
            {
                productName = "C",
                price = 20
            });

            product.Add(new Products
            {
                productName = "D",
                price = 15
            });

            return this;
        }

        public SuperMarketStock AddDeals()
        {
            deals.Add(new Deals
            {
                productName = "A",
                multiBuyQuantity = 3,
                multiBuyPrice = 130
            });

            deals.Add(new Deals
            {
                productName = "B",
                multiBuyQuantity = 2,
                multiBuyPrice = 45

            });

            return this;
        }


    }
}
