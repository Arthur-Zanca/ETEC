using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisEletro
{
    class Program
    {
        static void Main(string[] args)
        {
            tv tv1 = new tv(110, 95, 0, 0, 21);
            tv tv2 = new tv(220, 117, 0, 0, 29);
            tv2.gsLigado = true;
            tv2.gsCanal = 3;
            tv2.gsVolume = 25;
            System.Console.WriteLine("------------------------------------------");
            System.Console.WriteLine("TV 1");
            tv1.mostrarCaracteristicas();
            System.Console.WriteLine("TV 2");
            tv2.mostrarCaracteristicas();
            System.Console.ReadKey();
        }
    }
}
