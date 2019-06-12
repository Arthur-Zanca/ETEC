using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class calc
    {
        public double n1, n2, total;
        public void somar()
        {
            total = n1 + n2;
            System.Console.WriteLine("Soma = " + total);
            System.Console.WriteLine("");
        }
        public void subtrair()
        {
            total = n1 - n2;
            System.Console.WriteLine("Subtração = " + total);
            System.Console.WriteLine("");
        }
        public void dividir()
        {
            total = n1 / n2;
            System.Console.WriteLine("Divisão = " + total);
            System.Console.WriteLine("");
        }
        public void multiplicar()
        {
            total = n1 * n2;
            System.Console.WriteLine("Multíplicação = " + total);
            System.Console.WriteLine("");
        }
    }
}
//saur0n esteve aki ^^
