using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_o_mat
{
    class Konto
    {
        public string Id { get; set; }
        public double Saldo { get; set; }

        public Konto()
        {
            this.Id = Id;
        }
        public string GetId()
        {
            return Id;
        }
    }
}
