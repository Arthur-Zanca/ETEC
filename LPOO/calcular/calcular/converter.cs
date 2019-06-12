using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular
{
    class converter
    {
        public static double polegadaXcentimetro(double polegadas)
        {
            double centimetros = polegadas * 2.54;
            return centimetros;
        }
        public static double pesXmetros(double pes)
        {
            double metros = pes / 3.2808;
            return metros;
        }
        public static double milhaXkm(double milha)
        {
            double km = milha / 0.62137;
            return km;
        }
    }
}
//saur0n esteve aki ^^
