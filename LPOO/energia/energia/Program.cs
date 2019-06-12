using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace energia
{
    class Program
    {
        static void Main(string[] args)
        {
            uc uc1 = new uc();
            int opcao = 0;
            do
            {
                System.Console.WriteLine("-------------------------------------");
                System.Console.WriteLine(" 1 - Inserir dados da UC");
                System.Console.WriteLine(" 2 - Inserir leituras e gerar fatura");
                System.Console.WriteLine(" 3 - Alterar o valor do Kw/h");
                System.Console.WriteLine(" 0 - sair");
                System.Console.WriteLine("-------------------------------------");
                opcao = Convert.ToInt32(System.Console.ReadLine());
                if (opcao == 1)
                {
                    System.Console.WriteLine("Código: ");
                    uc1.gscodigo = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("Nome proprietário: ");
                    uc1.gsproprietario = System.Console.ReadLine();
                    System.Console.WriteLine("Endereço: ");
                    uc1.gsendereco = System.Console.ReadLine();
                }
                if (opcao == 2)
                {
                    System.Console.WriteLine("Leitura Atual: ");
                    uc1.gsleituraAtual = Convert.ToInt32(System.Console.ReadLine());
                    uc1.calcularFatura();
                    uc1.imprimirFatura();
                }
                if (opcao == 3)
                {
                    System.Console.WriteLine("Valor atual do Kw/h: ");
                    uc1.gsvalorkwh = Convert.ToDouble(System.Console.ReadLine());
                }
            }
            while (opcao != 0);
        }
    }
}
//saur0n esteve aki ^^