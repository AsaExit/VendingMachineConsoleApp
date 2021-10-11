using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineConsoleApp.Model;

namespace VendingMachineConsoleApp.Data
{
    public class VendingMachine : IVending

    {
        //---Fields
        readonly int[] moneyDenominations = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };

        int moneyPool;
        //---Properties
        public int MoneyPool { get { return moneyPool; } }

        public Product[] Products = new Product[] { new Toy(), new Food(), new Drink() };


        public Product Purchase(int Id)
        {
            Product productSelected = Array.Find(Products, product => product.productId == Id);

            if (productSelected == null)
            {
                throw new ArgumentException("the product you are looking for dose not exist");
            }

            if (productSelected.productPrice > moneyPool)
            {
                throw new ArgumentException("You dont have sufficient amout of money for this product?");
            }
            else
            {
                //Whats left of the moneyPoool
                moneyPool = moneyPool - productSelected.productPrice;
            }

            return productSelected;
        }
        public void ShowAll()
        {
            foreach (Product product in Products)
            {
                Console.WriteLine(product.Examine());
            }
            Console.WriteLine();
        }
        
        
        public void InsertMoney(int currency)
        {
            if (Array.Find(moneyDenominations, money => money == currency) != 0)
            {
                moneyPool += Convert.ToInt32(currency);
            }
            else
            {
                throw new ArgumentException("Have you inserted the correctfull amout to the denominations?");
            }
        }

        public Dictionary<int, int> EndTransaction(int productId)
        {

            Dictionary<int, int> changeDictionary = new Dictionary<int, int>();

            for (int i = moneyDenominations.Length - 1; i >= 0; i--)
            {
                int change = moneyPool / moneyDenominations[i];
                if (change != 0)
                {
                    changeDictionary.Add(moneyDenominations[i], change);
                }
                moneyPool = moneyPool % moneyDenominations[i];
            }// Do not allways trust what VS recommends...sure look at the dots at "moneyPool" says %= it dose not work
            return changeDictionary;
        }

    }// End of Class Name
}// End of namespace
