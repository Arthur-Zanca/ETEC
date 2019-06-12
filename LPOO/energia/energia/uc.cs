using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace energia
{
    class uc
    {
        private int codigo, leituraAtual, leituraAnterior, qtdkwh;
        private double valorkwh, valorTotal;
        private string proprietario, endereco;
        public int gscodigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int gsleituraAtual
        {
            get { return leituraAtual; }
            set { leituraAtual = value; }
        }
        public int gsleituraAnterior
        {
            get { return leituraAnterior; }
            set { leituraAnterior = value; }
        }
        public int gsqtdkwh
        {
            get { return qtdkwh; }
            set { qtdkwh = value; }
        }
        public double gsvalorkwh
        {
            get { return valorkwh; }
            set { valorkwh = value; }
        }
        public double gsvalorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }
        public string gsproprietario
        {
            get { return proprietario; }
            set { proprietario = value; }
        }
        public string gsendereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public void calcularFatura()
        {
            if (this.leituraAtual < this.leituraAnterior)
            {
                this.qtdkwh = this.leituraAtual + 10000 - this.leituraAnterior;
            }
            else
            {
                this.qtdkwh = this.leituraAtual - this.leituraAnterior;
            }
            this.valorTotal = this.qtdkwh * this.valorkwh;
        }
        public void imprimirFatura() 
        {
            System.Console.WriteLine("-------------------------------------");
            System.Console.WriteLine ("Código da Unidade:          " + codigo);
            System.Console.WriteLine ("Proprietário da UC:         " + proprietario);
            System.Console.WriteLine ("Endereço da UC:             " + endereco);
            System.Console.WriteLine ("Leitura Atual da UC:        " + leituraAtual);
            System.Console.WriteLine ("Leitura Anterior da UC:     " + leituraAnterior);
            System.Console.WriteLine ("Quantidade Consumida:       " + qtdkwh + " KW/h");
            System.Console.WriteLine ("Valor da Tarifa:            R$" + valorkwh);
            System.Console.WriteLine ("Valor a ser Pago:           R$" + valorTotal);
            leituraAnterior = leituraAtual;
        }
    }
}
//saur0n esteve aki ^^