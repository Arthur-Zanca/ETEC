using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoras
{
    class financeira: calculadora
    {
        public double j, c, i, t;
        public void jurosSimples()
        {
            System.Console.WriteLine(j = (c * i * t) / 100);
        }
    }
}
//saur0n esteve aki ^^