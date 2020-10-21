using tabuleiro;

namespace xadrez_console.tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get;protected set; }
        public int QTeMovimentos { get; set; }
        public Tabuleiro tabuleiro { get; set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
        {
            this.posicao = posicao;
            this.cor = cor;
            QTeMovimentos = 0;
            this.tabuleiro = tabuleiro;
        }
    }
}
