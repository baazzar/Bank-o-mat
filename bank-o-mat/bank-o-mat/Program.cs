using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_o_mat
{
    class Program
    {
        static void Main(string[] args)
        {
            Usluga bankomat = new Usluga();
            bankomat.Loop(); 
        }
    }
}
