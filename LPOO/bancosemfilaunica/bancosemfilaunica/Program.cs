using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancosemfilaunica
{
    class Program
    {
        static void Main(string[] args)
        {
            simuladorDeCaixaDeBanco cx1 = new simuladorDeCaixaDeBanco();
            simuladorDeCaixaDeBanco cx2 = new simuladorDeCaixaDeBanco();
            simuladorDeCaixaDeBanco cx3 = new simuladorDeCaixaDeBanco();
            cx2.proximoAtendimento(2);
            cx3.proximoAtendimento(3);
            cx1.proximoAtendimento(1);
            System.Console.ReadKey();
        }
    }
}
//saur0n esteve aki ^^