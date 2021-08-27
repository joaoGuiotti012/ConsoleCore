using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador: iJogador
    {
        public readonly string nome;

        public Jogador(string nome)
        {
            this.nome = nome;
        }

        public string Chuta()
        {
            return $"{nome} chutando \n";
        }
        public string Corre()
        {
            return $"{nome} correndo \n";
        }
        public string Passe()
        {
            return $"{nome} Passando \n";
        }
    }

}