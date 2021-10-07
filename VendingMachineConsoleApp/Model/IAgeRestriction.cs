using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Model
{
    public interface IAgeRestriction
    {
        bool PassAgeLimit(int age);
    }
}

