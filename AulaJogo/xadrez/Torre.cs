﻿using System;
using System.Collections.Generic;
using System.Text;
using AulaJogo.tabuleiro;

namespace AulaJogo.xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {

        }
        public override string ToString()
        {
            return "T";
        }
    }
}

