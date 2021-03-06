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
            productPrice = 30; //---Just a PRISLAPP------

        }
        public int AgeLimit { get; set; }
        public override string Examine()
        {
            return $"{productId}\t{productName}\t\t{productPrice}kr";
        }
        //---PassAgeLimit returns a bolean from userinput
        public bool PassAgeLimit(int age)
        {
            if (age >AgeLimit)
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
            return "If you are 18 years and older...Just enjoy ur Beer!";
        }

    }// End of Class Name
}// End of namespace