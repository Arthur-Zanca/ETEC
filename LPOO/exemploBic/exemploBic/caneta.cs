using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploBic
{
    class caneta
    {
        //caracteristicas
        public String modelo, cor;
        public int carga;
        public double ponta;
        public Boolean tampada;
        //funcionalidades
        public void escrever() // <<< metodo escrever (sempre verbo)
        {
            if (tampada == false)
            {
                System.Console.WriteLine("Estou escrevendo, seu idiota funcional");
            }
            else
            {
                System.Console.WriteLine("ERRO. Eu não consigo escrever, desgrama");
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
            System.Console.WriteLine("Tampada ? = " + tampada);
            System.Console.WriteLine("");
        }
    }
}
