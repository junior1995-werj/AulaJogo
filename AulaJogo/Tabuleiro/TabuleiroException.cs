using System;
using System.Collections.Generic;
using System.Text;

namespace AulaJogo.tabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException (String mensagem) : base(mensagem)
        {

        }
    }
}
