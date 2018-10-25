using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tabuleiro;

namespace Projeto_Xadrez
{
    class Programude
    {
        static void Main(string[] args)
        {

            //Posicao P = new Posicao(8, 8);
            //Console.WriteLine("Posição: " + P.linha + " Coluna: " + P.coluna);
            // Console.WriteLine("Posição: " + P);

            Tabuleiro tab = new Tabuleiro(8,8);

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();


        }
    }
}
