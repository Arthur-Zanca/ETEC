using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisEletro
{
    class geladeira:eletrodomestico
    {
        private double temperatura;
        public geladeira(int voltagem, int consumo, double temperatura)
            :base(false, voltagem, consumo)
        {
            this.temperatura = temperatura;
        }
        public double gsTemperatura
        {
            get { return temperatura; }
            set { temperatura = value; }
        }
    }
}
