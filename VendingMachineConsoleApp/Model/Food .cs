using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Model
{
    public class Food : Product
    {
        public Food()
        {
            productId = 2;
            productName = "Club Sandwich";
            productPrice = 25;
        }

        public override string Examine()
        {
            return $"{productId}\t{productName}\t\t{productPrice}kr";
        }

        public override string Use()
        {
            return "If you are really hungry and want something that tast good this is a good choise. ";
        }

    }//End of Class Name
}//End of namespace

