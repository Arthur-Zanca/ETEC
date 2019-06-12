using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoras
{
    class Program
    {
        static void Main(string[] args)
        {
            cientifica calcCientifica = new cientifica();
            calcCientifica.v1 = 10;
            System.Console.WriteLine("Valor elevado ao quadrado: ");
            calcCientifica.x2();
            calcCientifica.v1 = 5;
            calcCientifica.v2 = 3;
            System.Console.WriteLine("Multiplicação: ");
            calcCientifica.multiplicar();
            financeira calcFinaceira = new financeira();
            calcFinaceira.c = 5000;
            calcFinaceira.i = 5;
            calcFinaceira.t = 3;
            System.Console.WriteLine("-------------------------");
            System.Console.WriteLine("Rendimento da aplicação: ");
            calcFinaceira.jurosSimples();
            calcFinaceira.v1 = 5;
            calcFinaceira.v2 = 3;
            System.Console.WriteLine("Subtração");
            calcFinaceira.subtrair();
            System.Console.ReadKey();
        }
    }
}
//saur0n esteve aki ^^