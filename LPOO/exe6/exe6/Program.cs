using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe6
{
    class Program
    {
        static void Main(string[] args)
        {
            projetor p1 = new projetor();
            int opcao = 0;
            do
            {
                System.Console.WriteLine("1 - Exibir");
                System.Console.WriteLine("2 - Ligar");
                System.Console.WriteLine("3 - Desligar");
                System.Console.WriteLine("4 - Conectar Cabo");
                System.Console.WriteLine("5 - Desconectar Cabo");
                System.Console.WriteLine("6 - Status");
                System.Console.WriteLine("7 - Inserir Informações0");
                System.Console.WriteLine("0 - Sair");
                System.Console.WriteLine("");
                opcao = Convert.ToInt32(System.Console.ReadLine());
                if (opcao == 1)
                {
                    p1.exibir();
                }
                if (opcao == 2)
                {
                    p1.ligar();
                }
                if (opcao == 3)
                {
                    p1.desligar();
                }
                if (opcao == 4)
                {
                    p1.conectar();
                }
                if (opcao == 5)
                {
                    p1.desconectar();
                }
                if (opcao == 6)
                {
                    p1.status();
                }
                if (opcao == 7)
                {
                    System.Console.WriteLine("Digite o modelo: ");
                    p1.modelo = System.Console.ReadLine();
                    System.Console.WriteLine("Digite a cor: ");
                    p1.cor = System.Console.ReadLine();
                    System.Console.WriteLine("Digite a voltagem");
                    p1.alimentacao = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("Digite a resolução (altura): ");
                    p1.altura = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("Digite a resolução (largura): ");
                    p1.largura = Convert.ToInt32(System.Console.ReadLine());
                    System.Console.WriteLine("");
                }
            } 
            while (opcao != 0);
            System.Console.ReadKey();
        }
    }
}
//saur0n esteve aki ^^