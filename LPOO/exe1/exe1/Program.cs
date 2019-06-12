using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, total;
            System.Console.WriteLine("n1 = ");
            n1 = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("n2 = ");
            n2 = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("n3 = ");
            n3 = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("n4 = ");
            n4 = Convert.ToDouble(System.Console.ReadLine());
            total = n1 + n2 + n3 + n4;
            System.Console.WriteLine("soma = " + total);
            System.Console.ReadKey();
        }
    }
}
