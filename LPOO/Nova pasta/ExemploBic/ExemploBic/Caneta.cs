using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBic
{
    class Caneta
    {
         public String modelo, cor;
        public int carga;
        public double ponta;
        public Boolean tampada;

       public void escrever()
        {
            if ( tampada == false)
            {
                System.Console.WriteLine("Estou Escrevendo");

            }
            else
            {
                System.Console.WriteLine("Erro. Nao consigo escrever");

            }
        }
        public void tampar()
        {
            tampada = true;
        }
        public void destampar()
        {
            tampada = false;
        }
        public void status()
        {
            System.Console.WriteLine("Modelo = " + modelo);
            System.Console.WriteLine("Cor = " + cor);
            System.Console.WriteLine("Ponta = " + ponta);
            System.Console.WriteLine("Carga = " + carga);
            System.Console.WriteLine("Tampada? = " + tampada);

        }

    }
}
