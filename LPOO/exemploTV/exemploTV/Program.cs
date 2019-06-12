using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploTV
{
    class Program
    {
        static void Main(string[] args)
        {
            tv t1 = new tv();
            int opcao = 0;
            do
            {
                System.Console.WriteLine("");
                System.Console.WriteLine("O que você deseja fazer?");
                System.Console.WriteLine("1 - Ligar");
                System.Console.WriteLine("2 - Desligar");
                System.Console.WriteLine("3 - Procurar Canais");
                System.Console.WriteLine("4 - Próximo Canal");
                System.Console.WriteLine("5 - Canal Anterior");
                System.Console.WriteLine("6 - Aumentar Volume");
                System.Console.WriteLine("7 - Diminuir Volume");
                System.Console.WriteLine("8 - Exibir Status");
                System.Console.WriteLine("9 - Editar Status");
                System.Console.WriteLine("0 - Sair do Menu");
                opcao = Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("");
                if (opcao == 1)
                {
                    t1.ligar();
                }
                if (opcao == 2)
                {
                    t1.desligar();
                }
                if (opcao == 3)
                {
                    t1.procurar();
                }
                if (opcao == 4)
                {
                    t1.proximoCanal();
                }
                if (opcao == 5)
                {
                    t1.anteriorCanal();
                }
                if (opcao == 6)
                {
                    t1.aumentarVolume();
                }
                if (opcao == 7)
                {
                    t1.diminuirVolume();
                }
                if (opcao == 8)
                {
                    t1.status();
                }
                if (opcao == 9)
                {
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Digite o modelo: ");
                    t1.modelo = System.Console.ReadLine();
                    System.Console.WriteLine("Digite a tecnologia: ");
                    t1.tecnologia = System.Console.ReadLine();
                    System.Console.WriteLine("Digite a marca: ");
                    t1.marca = System.Console.ReadLine();
                    System.Console.WriteLine("Digite o tamanho: ");
                    t1.tamanho = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("");
                }
            }
            while (opcao != 0);
            System.Console.ReadKey();
        }
    }
}
//saur0n esteve aki ^^