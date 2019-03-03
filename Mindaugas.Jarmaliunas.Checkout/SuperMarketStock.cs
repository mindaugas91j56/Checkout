using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutTests
{
    public class SuperMarketStock
    {
        public int GetPrice(string barcode)
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
    }
}
