using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Model
{
    public class Drink : Product, IAgeRestriction
    {
        public Drink()
        {
            productId = 3;
            productName = "Beer";
            productPrice = 30;
        }
        public override string Examine()
        {
            return $"{productId}\t{productName}\t\t{productPrice}kr";
        }

        public override bool PassAgeLimit(int age)
        {
            if (age == 18)

            return true;
            Console.WriteLine("You are allowed to drink the beer!");
            
        }

        public override string Use()
        {
            return "You have to be 18 to drink a beer!";
        }
    }// End of Class Name
}// End of namespace