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

    }
}

