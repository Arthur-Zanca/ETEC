using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploTV
{
    class tv
    {
        public Boolean ligado;
        public String tecnologia, modelo, marca;
        public int tamanho, volume, canal;
        public void ligar()
        {
            ligado = true;
        }
        public void desligar()
        {
            ligado = false;
        }
        public void procurar()
        {
            System.Console.WriteLine("Procurando canais........");
            System.Console.WriteLine("Fim da procura.");
        }
        public void aumentarVolume()
        {
            volume++;
        }
        public void diminuirVolume()
        {
            volume--;
        }
        public void proximoCanal()
        {
            canal++;
        }
        public void anteriorCanal()
        {
            canal--;
        }
        public void status()
        {
            System.Console.WriteLine("Marca = " + marca);
            System.Console.WriteLine("Tecnologia = " + tecnologia);
            System.Console.WriteLine("Modelo = " + modelo);
            System.Console.WriteLine("Tamanho = " + tamanho);
            System.Console.WriteLine("Volume = " + volume);
            System.Console.WriteLine("Canal = " + canal);
            System.Console.WriteLine("Esta ligado? " + ligado);
        }
    }
}
//saur0n esteve aki ^^