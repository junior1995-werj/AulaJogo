using System;
using AulaJogo.tabuleiro;
using AulaJogo.xadrez;

namespace AulaJogo
{
    //jogo de Xadrez

    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.Colocarpeca(new Torre(tab,Cor.preta), new Posicao(0, 0));
            tab.Colocarpeca(new Rei (tab,Cor.branca),new Posicao(1, 3));
            tab.Colocarpeca(new Torre (tab,Cor.amarela),new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
