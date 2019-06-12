using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaConstrutor
{
    class conta
    {
        private int numero;
        private double saldo;
        public conta(int numero, double saldo) //metodo construtor
        {
            this.numero = numero;
            this.saldo = saldo;
            System.Console.WriteLine("Construtor executado");
            System.Console.WriteLine("Número da conta: " + this.numero);
            System.Console.WriteLine("Saldo da conta: " + this.saldo);
        }
        public conta()
        {
            System.Console.WriteLine("Construtor executado");
        }
    }
}
//saur0n esteve aki ^^ 
