using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sisEletro
{
    class eletrodomestico
    {
        private Boolean ligado;
        private int voltagem, consumo;
        public eletrodomestico(Boolean ligado, int voltagem, int consumo)
        {
            this.ligado = ligado;
            this.voltagem = voltagem;
            this.consumo = consumo;
        }
        public Boolean isLigado()
        {
            return ligado;
        }
        public Boolean gsLigado
        {
            get { return ligado; }
            set { ligado = value; }
        }
        public int gsVoltagem
        {
            get { return voltagem; }
            set { voltagem = value; }
        }
        public int gsConsumo
        {
            get { return consumo; }
            set { consumo = value; }
        }
    }
}
