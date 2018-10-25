using System;
using tabuleiro;

namespace Projeto_Xadrez
{
    class Tela
    {

        //metod VOID não retorna nada:
        public static void imprimirTabuleiro(Tabuleiro tab)
        {

            // percorrendo as linhas
            for (int i = 0; i < tab.linhas ; i++)
            {
                // percorrendo as colunas
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.peca(i, j) == null)
                    {
                        Console.Write("_ ");
                    }
                    else
                    {
                        Console.Write(tab.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();

            }

        }


    }
}
