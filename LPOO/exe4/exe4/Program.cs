using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoA, anoN, idade, idadeB;
            System.Console.WriteLine("ano atual = ");
            anoA = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine("ano de nascimento = ");
            anoN = Convert.ToInt32(System.Console.ReadLine());
            idade = anoA - anoN;
            idadeB = 2020 - anoN;
            System.Console.WriteLine("idade atual: " + idade + " anos");
            System.Console.WriteLine("idade em 2020: " + idadeB + " anos");
            Console.ReadKey();
        }
    }
}
