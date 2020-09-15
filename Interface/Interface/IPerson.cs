using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Interface
{
    public interface IPerson
    {
        string Name { get; set; } // we dont need at define access modifies (public , private)
        int Age { get; set; }

        string Role { get; set; }

        void PrintRole();  // implements at student and teacher class


    }
}
