﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro
{
    class Peca
    {

        public Posicao posicao { get; set; }

        //PROTECTED -> só pode ser acessada pela subclasse dela. 
        public Cor cor { get; protected set; }

        public int qteMovimentos { get; protected set; }

        public Tabuleiro tab { get; protected set; }


        // Criando o Construtor da Classe

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }

    }


}