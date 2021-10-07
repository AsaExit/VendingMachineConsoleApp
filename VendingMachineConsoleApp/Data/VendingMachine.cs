using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineConsoleApp.Model;

namespace VendingMachineConsoleApp.Data
{
    class VendingMachine : IVending

    {
        // Fields
        readonly int[] moneyDenominations = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };

        readonly int moneyPool;

        public int MoneyPool { get { return moneyPool; } }

        public Product[] Products = new Product[] { new Toy(), new Food(), new Drink() };

        // Properties
        public int[] MoneyDenominations { get { return moneyDenominations; } }
        public Dictionary<int, int> EndTransaction(int productId)
        {
            throw new NotImplementedException();
        }

        public void InsertMoney(int currency)
        {
            throw new NotImplementedException();
        }

        public Product Purchase(int id)
        {
            throw new NotImplementedException();
        }

        public void ShowAll()
        {
            throw new NotImplementedException();
        }
    }// End of Class Name
}// End of namespace
