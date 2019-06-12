using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe3
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, bas, area;
            System.Console.WriteLine("altura = ");
            altura = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("base = ");
            bas = Convert.ToDouble(System.Console.ReadLine());
            area = (altura * bas) / 2;
            System.Console.WriteLine("área do triangulo = " + area);
            System.Console.ReadKey();
        }
    }
}
