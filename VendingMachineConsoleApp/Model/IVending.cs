using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Model
{
    public interface IVending
    {
        //Buy a product
        Product Purchase(int id);

        //Show all products.
        void ShowAll();

        //Add money to the pool.
        void InsertMoney(int currency);

        //Returns whats left in appropriate currency of change(Dictionary).
        Dictionary<int, int> EndTransaction(int productId);

    }
}
