using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBic
{
    class Program
    {
        static void Main(string[] args)
        {
            Caneta c1 = new Caneta();

            int opcao = 0;

            do
            {
                System.Console.WriteLine("1 - escrever");
                System.Console.WriteLine("2 - tampar");
                System.Console.WriteLine("3 - Destamapar");
                System.Console.WriteLine("4 - Status");
                System.Console.WriteLine("5 - Inserir Dados");
                System.Console.WriteLine("6 - Sair");
                opcao = Convert.ToInt32(System.Console.ReadLine());

                if(opcao == 1)
                {
                    c1.escrever();
                }
                if(opcao == 2)
                {
                    c1.tampar();
                }
                if(opcao == 3)
                {
                    c1.destampar();
                }
            } while (opcao != 0);

            System.Console.ReadKey();

        }
    }
}
