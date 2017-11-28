using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_o_mat
{
    class Usluga : Konto
    {
        private char key;
        private double vol;

        public Usluga() : base()
        {

        }
        public void GetKey()
        {
            key = Console.ReadKey().KeyChar;
        }
        public void GetVol()
        {
            vol = Convert.ToInt32(Console.ReadLine());
        }
        public void NewAcc()
        {
            //dodaj konto do listy kont
        }
        public void Acc()
        {
            Console.WriteLine("1: SIGN IN");
            Console.WriteLine("2: REGISTER");
            GetKey();
            if (key == '1')
                GetId();
            else if (key == '2')
                NewAcc();
            else key = '0';
                   
        }
        public void Op()
        {
            Console.WriteLine("1: OUT");
            Console.WriteLine("2: IN");
            Console.WriteLine("3: BALANCE");
            Console.WriteLine("4: LOG");
            GetKey();
            if (key == '1')
                Out(vol);
            else if (key == '2')
                In(vol);
            else if (key == '3')
                Info();
            else if (key == '4')
                Log();
            else key = '0';

        }
        public void Loop()
        {
            while (key != 0)
            {
                Acc();
                Op();
            }
        }
        public double In(double pln)
        {
            return Saldo = Saldo + pln;
        }
        public double Out(double pln)
        {
            return Saldo = Saldo - pln;
        }
        public string Info()
        {
            return String.Format("{0}", this.Saldo);
        }
        public void Log()
        {
            //drukuj log do txt
        }
    }
}