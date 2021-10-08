using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Model
{
    public class Toy : Product, IAgeRestriction
    {
        public Toy()
        {
            productId = 1;
            productName = "Stuffed animal Cow";
            productPrice = 100;//---Just a PRISLAPP------
        }
        public int AgeLimit { get; set; }
        public override string Examine()
        {
            return $"{productId}\t{productName}\t\t{productPrice}kr";
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
            return "If you need conferting or just a cuddling friend, so hugg it!";
        }
    }// End of Class Name
}// End of namespace

