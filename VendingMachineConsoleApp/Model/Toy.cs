using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Model
{
    class Toy : Product, IAgeRestriction
    {
        public Toy()
        {
            productId = 1;
            productName = "Stuffed animal Cow";
            productPrice = 100;
        }
        public int AgeLimit { get; set; }
        public override string Examine()
        {
            return $"{productId}\t{productName}\t\t\t{productPrice}kr";
        }
        //---PassAgeLimit returns a bolean from userinput
        public bool PassAgeLimit(int age)
        {
            if (age > AgeLimit)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public override string Use()
        {
            return "If you need conferting or just a cuddling friend, so hugg it!\n";
        }
    }// End of Class Name
}// End of namespace

