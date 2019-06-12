using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe6
{
    class projetor
    {
        public String cor, modelo;
        public int alimentacao, altura, largura;
        public Boolean ligado, cabo;
        public void exibir()
        {
            if (ligado == true)
            {
                if (cabo == false)
                {
                    System.Console.WriteLine("Projetor ligado, conecte um cabo");
                    System.Console.WriteLine("");
                }
                if (cabo == true)
                {
                    System.Console.WriteLine("[IMAGINE UM SLIDESHOW AQUI]");
                    System.Console.WriteLine("");
                }
            }
            if (ligado == false)
            {
                System.Console.WriteLine("Projetor desligado, ligue-o");
                System.Console.WriteLine("");
            }      
        }
        public void ligar()
        {
            ligado = true;
        }
        public void desligar()
        {
            ligado = false;
        }
        public void status()
        {
            System.Console.WriteLine("Modelo = " + modelo);
            System.Console.WriteLine("Cor = " + cor);
            System.Console.WriteLine("Alimentação = " + alimentacao);
            System.Console.WriteLine("Resolução = " + largura + " x " + altura);
            System.Console.WriteLine("Ligado ? = " + ligado);
            System.Console.WriteLine("");
        }
        public void conectar()
        {
            cabo = true;
        }
        public void desconectar()
        {
            cabo = false;
        }
    }
}
//saur0n esteve aki ^^