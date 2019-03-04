using System.Collections.Generic;
using System.Linq;

namespace Mindaugas.Jarmaliunas.Checkout
{
    public class SuperMarketsuperMarket : ICheckout
    {
        private List<Products> product = new List<Products>();
        private List<Deals> deals = new List<Deals>();
        private List<string> barcodes = new List<string>();

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

        public string FirstMultiBuyOptionCode()
        {
            return deals[0].productName;
        }

        public string SecondMultiBuyOptionCode()
        {
            return deals[1].productName;
        }

        public int GetItemMultiBytQuantityById(int id)
        {
            return deals[id].multiBuyQuantity;
        }

        public void Scan(string item)
        {
            barcodes.Add(item);
        }

        public List<string> GetItemCodeList()
        {
            return barcodes;
        }

        public void GenerateSuperMarketItems()
        {
            AddSuperMarketItem();
            AddDeals();
        }

        public int GetTotalPrice()
        {
            var ItemList = GetItemCodeList();
            var totalPrice = 0;
            int multiBuy = 0;
            int total = 0;

            for (int i = 0; i < ItemList.Count; i++)
            {
                if (!DoesProductHaveMultiBuyOption(ItemList[i]))
                {
                    total += GetPrice(ItemList[i]);
                }
            }

            var itemCodeBelongsToMultiBuy = ItemList.Contains(FirstMultiBuyOptionCode());
            int numberOfItemsA = ItemList.Where(x => x.Contains(FirstMultiBuyOptionCode())).Count();

            if (numberOfItemsA >= GetItemMultiBytQuantityById(0))
            {
                int pairsOfMultiples = numberOfItemsA % GetItemMultiBytQuantityById(0);
                multiBuy = GetMultiBuyPrice(FirstMultiBuyOptionCode()) * (numberOfItemsA / GetItemMultiBytQuantityById(0));

                multiBuy += GetPrice(FirstMultiBuyOptionCode()) * pairsOfMultiples;
                totalPrice += multiBuy;

            }
            else if (ItemList.Contains(FirstMultiBuyOptionCode()))
            {
                totalPrice += numberOfItemsA * GetPrice(FirstMultiBuyOptionCode());
            }

            var itemCodeBelongsToMultiBuyTwo = ItemList.Contains(SecondMultiBuyOptionCode());
            int numberOfItemsB = ItemList.Where(x => x.Contains(SecondMultiBuyOptionCode())).Count();


            if (numberOfItemsB >= GetItemMultiBytQuantityById(1))
            {
                int pairsOfMultiples = numberOfItemsB % GetItemMultiBytQuantityById(1);
                multiBuy = GetMultiBuyPrice(SecondMultiBuyOptionCode()) * (numberOfItemsB / GetItemMultiBytQuantityById(1));

                multiBuy += GetPrice(SecondMultiBuyOptionCode()) * pairsOfMultiples;
                totalPrice += multiBuy;

            }
            else if (ItemList.Contains(SecondMultiBuyOptionCode()))
            {
                totalPrice += numberOfItemsB * GetPrice(SecondMultiBuyOptionCode());
            }

            return totalPrice + total;
        }

        public SuperMarketsuperMarket AddSuperMarketItem()
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

        public SuperMarketsuperMarket AddDeals()
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
