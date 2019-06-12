using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancosemfilaunica
{
    class simuladorDeCaixaDeBanco
    {
        public static int numeroDoCliente = 0;
        public void proximoAtendimento(int Caixa)
        {
            numeroDoCliente++;
            System.Console.WriteLine("Cliente com a senha: " + numeroDoCliente + " favor dirigir-se ao caixa nº " + Caixa);
        }
    }
}
//saur0n esteve aki ^^
