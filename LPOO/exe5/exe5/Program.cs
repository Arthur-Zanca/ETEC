using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe5
{
    class Program
    {
        static void Main(string[] args)
        {
            double basm, basM, alt, area;
            System.Console.WriteLine("base maior = ");
            basM = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("base menor = ");
            basm = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("altura = ");
            alt = Convert.ToDouble(System.Console.ReadLine());
            area = ((basM + basm) * alt) / 2;
            System.Console.WriteLine("area = " + area);
            Console.ReadKey();
        }
    }
}
