using System;
using tabuleiro;

namespace tabuleiro
{
    class Peca
    {
        private object tab;

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; set; }

        public Peca(Cor cor, Tabuleiro tabuleiro)
        {
            this.posicao = null;
            this.cor = cor;
            this.qteMovimentos = 0;
            this.tabuleiro = tabuleiro;
        }
        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        public void decrementarQteMovimentos()
        {
            qteMovimentos--;
        }

        public Peca(object tab, Cor cor)
        {
            this.tab = tab;
            this.cor = cor;
        }
    }
}
