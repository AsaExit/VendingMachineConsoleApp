using System;
using VendingMachineConsoleApp.Data;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Model
{
    public abstract class Product
    {
        public int productId { get; set; }
        public int productPrice { get; set; }
        public string productName { get; set; }

        public abstract string Examine();
        public abstract string Use();


    }//End of Abstract class
}//End of namespace

    

