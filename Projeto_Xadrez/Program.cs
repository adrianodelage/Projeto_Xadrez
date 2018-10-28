using System;
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
            //Console.WriteLine("Posição: " + P);


            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();


                // Console.WriteLine("");
                Tela.imprimirTabuleiro(partida.tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }


            //PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            //Console.WriteLine(pos);
            //Console.WriteLine(pos.toPosicao());


            Console.ReadLine();


        }
    }
}
