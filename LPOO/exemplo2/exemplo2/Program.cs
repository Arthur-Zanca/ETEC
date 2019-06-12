using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media;
            System.Console.WriteLine("n1 = ");
            n1 = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("n2 = ");
            n2 = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("n3 = ");
            n3 = Convert.ToDouble(System.Console.ReadLine());
            media = (n1 + n2 + n3) / 3;
            System.Console.WriteLine("média = " + media);
            System.Console.ReadKey();
        }
    }
}
//saur0n esteve aki ^^