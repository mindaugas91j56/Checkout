using System;

namespace Mindaugas.Jarmaliunas.Checkout
{
    class Checkout
    {
        static void Main(string[] args)
        {
            var stock = new SuperMarketStock();
            stock.AddStock();
            stock.AddDeals();


            Console.WriteLine("Welcome to Mindaugas Checkout");
            Console.WriteLine("To Scan item code by entering barcode. In order to exit press ESC");


            ConsoleKeyInfo inputKey;

            while (true)
            {
                inputKey = Console.ReadKey(true);
                if (inputKey.Key == ConsoleKey.Escape)
                    break;


                if (stock.DoesProductExist(inputKey.Key.ToString()))
                {

                    stock.AddScannedItem(inputKey.Key.ToString());
                    var allBarCodesList = stock.GetItemCodeList();

                    var total = stock.calculateTotalPrice(allBarCodesList);

                    Console.WriteLine("Total price " + total);
                }
                else
                {
                    Console.WriteLine("Item code has been not recornised please re-enter");
                }
            }
        }
    }
}

