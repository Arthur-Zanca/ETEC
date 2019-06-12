using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            do
            {
                System.Console.WriteLine("------------------------------------------");
                System.Console.WriteLine("CONVERSOR DE MEDIDAS IMPERIAL x MÉTRICO:");
                System.Console.WriteLine("");
                System.Console.WriteLine("Selecione uma opção de conversão:");
                System.Console.WriteLine("(1) Polegadas para Centimetros");
                System.Console.WriteLine("(2) Pés para Metros");
                System.Console.WriteLine("(3) Milhas para Kilometros");
                System.Console.WriteLine("(0) Sair");
                System.Console.WriteLine("------------------------------------------");
                opcao = Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("");
                if ( opcao < 4 && opcao >= 0 )
                {
                    if (opcao == 1)
                    {
                        System.Console.WriteLine("Polegadas: ");
                        double valor = Convert.ToDouble(System.Console.ReadLine());
                        System.Console.WriteLine("Centimetros: " + Math.Round(converter.polegadaXcentimetro(valor), 2) + "cm");
                        System.Console.WriteLine("");
                    }
                    if (opcao == 2)
                    {
                        System.Console.WriteLine("Pés: ");
                        double valor = Convert.ToDouble(System.Console.ReadLine());
                        System.Console.WriteLine("Metros: " + Math.Round(converter.pesXmetros(valor), 2) + "m");
                        System.Console.WriteLine("");
                    }
                    if (opcao == 3)
                    {
                        System.Console.WriteLine("Milhas: ");
                        double valor = Convert.ToDouble(System.Console.ReadLine());
                        System.Console.WriteLine("Kilometros: " + Math.Round(converter.milhaXkm(valor), 2) + "km");
                        System.Console.WriteLine("");
                    }
                }
                else
                {
                    System.Console.WriteLine("Opção inválida, escolha outra");
                }
            }
            while (opcao != 0);
            System.Console.ReadKey();
        }
    }
}
//saur0n esteve aki ^^