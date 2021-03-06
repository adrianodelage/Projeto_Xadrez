﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    // abstract por conta do movimentosPossiveis
    abstract class Peca
    {        

        public Posicao posicao { get; set; }

        //PROTECTED -> só pode ser acessada pela subclasse dela. 
        public Cor cor { get; protected set; }

        public int qteMovimentos { get; protected set; }

        public Tabuleiro tab { get; protected set; }


        // Criando o Construtor da Classe

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }

        public void incrementarQteMovimentos() { qteMovimentos++; }



        //Abstratct, ou sej, genérico -> Vai ser implementado em outra classe
        //Lembrando que nesse caso a MÃE tem que ser abstrata também.
        public abstract bool[,] movimentosPossiveis();
    }


}
