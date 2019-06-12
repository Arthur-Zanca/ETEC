using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBancaria
{
    class conta
    {
        private int numero;
        private double saldo, tadm, valor;

        public int gsnumero
        {
            get { return numero; }
            set { numero = value; }
        }
        public double gstadm
        {
            get { return tadm; }
            set { tadm = value; }
        }
        public double gssaldo
        {
            get { return saldo; }
        }
        public double gsvalor
        {
            get { return valor; }
            set { valor = value; }
        }
        public void sacar(double valor)
        {
            if (saldo > valor)
            {
                
                saldo -= valor;
                System.Console.WriteLine("Operação efetuada");
                System.Console.WriteLine("");
            }
            else
            {
                System.Console.WriteLine("Saldo insuficiente");
                System.Console.WriteLine("");
            }
        }
        public void depositar(double valor)
        {
            saldo += valor;
            System.Console.WriteLine("Operação efetuada");
            System.Console.WriteLine("");
        }
    }
}
// saur0n esteve aki ^^