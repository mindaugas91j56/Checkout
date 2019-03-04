using System;

namespace Mindaugas.Jarmaliunas.Checkout
{
    class Checkout
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo inputKey;
            var superMarket = new SuperMarketsuperMarket();
            superMarket.GenerateSuperMarketItems();

            Console.WriteLine("Welcome to Mindaugas Checkout");
            Console.WriteLine("To Scan item code by entering barcode. In order to exit press ESC");

            while (true)
            {
                inputKey = Console.ReadKey(true);
                if (inputKey.Key == ConsoleKey.Escape)
                    break;

                if (superMarket.DoesProductExist(inputKey.Key.ToString()))
                {
                    superMarket.Scan(inputKey.Key.ToString());
                    Console.WriteLine("Thank you for using Mindaugas Checkout");
                    superMarket.GetItemCodeList().ForEach(a => Console.WriteLine("Reciept: " + a));
                    Console.WriteLine("Total price :" + superMarket.GetTotalPrice());
                }
                else
                {
                    Console.WriteLine("Item code has been not recornised please re-enter");
                }
                Console.WriteLine("----------------------------------------------------------");
            }
        }
    }
}

