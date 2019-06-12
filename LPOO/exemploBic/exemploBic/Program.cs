using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploBic
{
    class Program
    {
        static void Main(string[] args)
        {
            caneta c1 = new caneta();

            int opcao = 0;

            do
            {
                System.Console.WriteLine("1 - escrever");
                System.Console.WriteLine("2 - tampar");
                System.Console.WriteLine("3 - Destamapar");
                System.Console.WriteLine("4 - Status");
                System.Console.WriteLine("5 - Inserir Dados");
                System.Console.WriteLine("0 - Sair");
                System.Console.WriteLine("");
                opcao = Convert.ToInt32(System.Console.ReadLine());

                if (opcao == 1)
                {
                    c1.escrever();
                }
                if (opcao == 2)
                {
                    c1.tampar();
                }
                if (opcao == 3)
                {
                    c1.destampar();
                }
                if (opcao == 4)
                {
                    c1.status();
                }
                if (opcao == 5)
                {
                    System.Console.WriteLine("digite o modelo: ");
                    c1.modelo = System.Console.ReadLine();
                    System.Console.WriteLine("digite a cor: ");
                    c1.cor = System.Console.ReadLine();
                    System.Console.WriteLine("digite a carga: ");
                    c1.carga = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("digite o valor da ponta: ");
                    c1.ponta = Convert.ToDouble(System.Console.ReadLine());

                }
            } while (opcao != 0);

            System.Console.ReadKey();
        }
    }
}
