using tabuleiro;

namespace xadrez_console.tabuleiro
{
    class Peca
    {
        private object tab;

        public Posicao posicao { get; set; }
        public Cor cor { get;protected set; }
        public int QTeMovimentos { get; set; }
        public Tabuleiro tabuleiro { get; set; }

        public Peca(Cor cor, Tabuleiro tabuleiro)
        {
            this.posicao = null;
            this.cor = cor;
            QTeMovimentos = 0;
            this.tabuleiro = tabuleiro;
        }

        public Peca(object tab, Cor cor)
        {
            this.tab = tab;
            this.cor = cor;
        }
    }
}
