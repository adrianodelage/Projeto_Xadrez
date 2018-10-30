using System;
using tabuleiro;
namespace xadrez
{
    class Torre : Peca
    {
        //construtor
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }


        public override string ToString()
        {
            return "T";
        }


        // verificar se as casas acima e ao lado estão livres
        private bool podeMover(Posicao pos)
        {
            //recebe a posicação da peça
            Peca p = tab.peca(pos);

            // se for null ou se a cor é a cor do adversário, recebe true, ou seja, está livre ou  pode comer.
            return p == null || p.cor != this.cor;
        }


        // override aqui indica que estou sobescrevendo o método aqui
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);


            // tem que ser dentro de um while, pois tenho que verificar se:
            // a casa está livre;
            // se a peça é do adversário
            // ou se não chegou ao final


            // verificando acima
            pos.definirvalores(posicao.linha - 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                // se achar peça adversário para;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha = pos.linha - 1;
            } 

            // Abaixo
            pos.definirvalores(posicao.linha + 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                // se achar peça adversário para;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha = pos.linha + 1;
            }


            // Direita
            pos.definirvalores(posicao.linha, posicao.coluna +1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                // se achar peça adversário para;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha = pos.coluna + 1;
            }


            // esquerda
            pos.definirvalores(posicao.linha, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;

                // se achar peça adversário para;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.linha = pos.coluna - 1;
            }

            return mat;

        }

    }
}

