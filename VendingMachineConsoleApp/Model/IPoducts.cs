using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Model
{
    interface IPoducts
    {
        bool PassAgeLimit(int age);
    }
}
