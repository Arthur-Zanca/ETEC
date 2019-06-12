using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            calc c1 = new calc();
            int opcao = 0;
            do
            {
                System.Console.WriteLine("");
                System.Console.WriteLine("Escolha uma opção: ");
                System.Console.WriteLine("1 - Soma");
                System.Console.WriteLine("2 - Subtração");
                System.Console.WriteLine("3 - Divisão");
                System.Console.WriteLine("4 - Multiplicação");
                System.Console.WriteLine("5 - Inserir Valores");
                System.Console.WriteLine("0 - Sair");
                System.Console.WriteLine("");
                opcao = Convert.ToInt32(System.Console.ReadLine());
                if (opcao == 1)
                {
                    c1.somar();
                }
                if (opcao == 2)
                {
                    c1.subtrair();
                }
                if (opcao == 3)
                {
                    c1.dividir();
                }
                if (opcao == 4)
                {
                    c1.multiplicar();
                }
                if (opcao == 5)
                {
                    System.Console.WriteLine("Insira o primeiro valor: ");
                    c1.n1 = Convert.ToDouble(System.Console.ReadLine());
                    System.Console.WriteLine("Insira o segundo valor: ");
                    c1.n2 = Convert.ToDouble(System.Console.ReadLine());
                    System.Console.WriteLine("");
                }
            }
            while (opcao != 0);
            System.Console.ReadKey();
        }
    }
}
//saur0n esteve aki ^^
