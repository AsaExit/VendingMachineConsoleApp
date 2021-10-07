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
        public override string Examine()
        {
            return $"{productId}\t{productName}\t\t\t{productPrice}kr";
        }

        public bool PassAgeLimit(int age)
        {
            throw new NotImplementedException();
        }

        public override string Use()
        {
            return "If you need conferting or just a cuddling friend, so hugg it!\n";
        }
    }// End of Class Name
}// End of namespace

