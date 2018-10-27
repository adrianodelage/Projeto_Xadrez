using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tabuleiro;
using xadrez;

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

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();


        }
    }
}
