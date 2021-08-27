using System;
using GameTop.Interface;

namespace GameTop
{
    public class JogoFODA
    {
        
        public readonly iJogador _jogadorA;
        public readonly iJogador _jogadorB;

        public JogoFODA(iJogador jogadorA, iJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
        }

        public void IniciarJogo() {
            Console.Write(_jogadorA.Corre());
            Console.Write(_jogadorA.Corre());
            Console.Write(_jogadorA.Chuta());

            Console.Write(_jogadorB.Chuta());
            Console.Write(_jogadorB.Passe());
            Console.Write(_jogadorB.Passe());
        }

    }
}