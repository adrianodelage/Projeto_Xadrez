using System;
using tabuleiro;
namespace xadrez
{
    class Rei : Peca
    {
        //construtor
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }


        public override string ToString()
        {
            return "R";
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

            Posicao pos = new Posicao(0,0);

            // verifica a acima;
            pos.definirvalores(posicao.linha - 1, posicao.coluna);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // verifica a acima a direita;
            pos.definirvalores(posicao.linha - 1, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // verifica a direita;
            pos.definirvalores(posicao.linha, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }


            // verifica abaixo a direita;
            pos.definirvalores(posicao.linha + 1, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }


            // verifica abaixo;
            pos.definirvalores(posicao.linha + 1, posicao.coluna);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // verifica abaixo a esquerda;
            pos.definirvalores(posicao.linha + 1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // verifica  esquerda;
            pos.definirvalores(posicao.linha, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            // verifica esquerda a cima;
            pos.definirvalores(posicao.linha -1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }

    }
}

