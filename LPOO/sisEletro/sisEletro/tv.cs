using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisEletro
{
    class tv:eletrodomestico
    {
        private int canal, volume, tamanho;
        public tv(int voltagem, int consumo, int canal, int volume, int tamanho)
            : base(false, voltagem, consumo)
        {
            this.canal = canal;
            this.volume = volume;
            this.tamanho = tamanho;
        }
        public int gsCanal
        {
            get { return canal; }
            set { canal = value; }
        }
        public int gsVolume
        {
            get { return volume; }
            set { volume = value; }
        }
        public int gsTamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }
        public void mostrarCaracteristicas()
        {
            System.Console.WriteLine("------------------------------------------ ");
            System.Console.WriteLine("Essa TV tem as seguintes especificações: \n" + 
                                     "\n" +
                                     " Tamanho.......... " + this.gsTamanho + "'\n" +
                                     " Voltagem......... " + this.gsVoltagem + "V\n" +
                                     " Consumo/h........ " + this.gsConsumo + "W");
            if (this.isLigado())
            {
                System.Console.WriteLine(" Ligado........... Sim\n" + 
                                         " Canal............ " + this.gsCanal + "\n" +
                                         " Volume........... " + this.gsVolume + "\n");
                System.Console.WriteLine("------------------------------------------");
            }
            else{
                System.Console.WriteLine(" Ligado........... Não\n");
                System.Console.WriteLine("------------------------------------------");
            }

        }
    }
}
