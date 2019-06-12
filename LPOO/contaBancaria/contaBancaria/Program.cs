using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            conta c1 = new conta();
            int opcao = 0;
            do
            {
                System.Console.WriteLine("O que você deseja fazer?");
                System.Console.WriteLine("1 - Ver Saldo");
                System.Console.WriteLine("2 - Depositar");
                System.Console.WriteLine("3 - Sacar");
                System.Console.WriteLine("0 - Sair do Menu");
                opcao = Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("");
                if (opcao == 1)
                {
                    System.Console.WriteLine("Saldo atual: R$" + c1.gssaldo);
                    System.Console.WriteLine("");
                }
                if (opcao == 2)
                {
                    System.Console.WriteLine("Valor a depositar: ");
                    c1.depositar(c1.gsvalor = Convert.ToDouble(System.Console.ReadLine()));
                    System.Console.WriteLine("");
                }
                if (opcao == 3)
                {
                    System.Console.WriteLine("Valor a sacar: ");
                    c1.sacar(c1.gsvalor = Convert.ToDouble(System.Console.ReadLine()));
                    System.Console.WriteLine("");
                }               
            }
            while (opcao != 0);
            System.Console.ReadKey();
        }
    }
}
//saur0n esteve aki ^^