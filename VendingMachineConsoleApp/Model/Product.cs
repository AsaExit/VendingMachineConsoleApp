using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Model
{
    public abstract class Product : IPoducts
    {
        public int productId { get; set; }
        public int productPrice { get; set; }
        public string productName { get; set; }

        public abstract string Examine();
        public abstract string Use();


    }//End of Abstract class
}//End of namespace

    

