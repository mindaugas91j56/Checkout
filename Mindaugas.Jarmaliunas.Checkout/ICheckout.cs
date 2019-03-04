using System;
using System.Collections.Generic;
using System.Text;

namespace Mindaugas.Jarmaliunas.Checkout
{
    interface ICheckout
    {
        void Scan(string item);
        int GetTotalPrice();
    }
}
