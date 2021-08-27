using System;
using System.Collections.Generic;
using GameTop.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(
                new Jogador("Pelé"),
                new Jogador2()
            );  

            jogo.IniciarJogo();
        }
    }

}
