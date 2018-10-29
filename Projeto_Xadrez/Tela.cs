using System;
using tabuleiro;
using xadrez;

namespace Projeto_Xadrez
{
    class Tela
    {

        //metod VOID não retorna nada:
        public static void imprimirTabuleiro(Tabuleiro tab)
        {

            // percorrendo as linhas
            for (int i = 0; i < tab.linhas; i++)
            {
                Console.Write( 8 - i + " ");
                // percorrendo as colunas
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("_ ");
                    }
                    else
                    {
                        //Console.Write(tab.peca(i, j) + " ");
                        Tela.imprimirPeca(tab.peca(i, j));
                        Console.Write("");
                    }
                }
                Console.WriteLine();

            }

            Console.Write("  A B C D E F G H");
        }

        public static PosicaoXadrez lerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna, linha);
        }


        public static void imprimirPeca(Peca peca)
        {
            if (peca.cor == Cor.Branco)
            {
                Console.Write(peca);
            }
            else
            {
                // pegando a cor do consolte para guardar em uma variavel auxiliar
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

    }
}
