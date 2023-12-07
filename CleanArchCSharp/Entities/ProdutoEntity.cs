

namespace FiapCAVendas.Entities
{
    internal class ProdutoEntity
    {
        public string Nome { get; }
        public string Identificacao { get; }
        public double Preco
        {
            private set
            {
                Preco = value;
            }

            get
            {
                return Preco * Desconto;
            }
        }
        private double Desconto;

        public ProdutoEntity(string nome, string identificacao, double preco)
        {
            Nome = nome;
            Identificacao = identificacao;
            Preco = preco;
            Desconto = 1;
        }

        public void DefinirDesconto(double porcentagem)
        {
            Desconto = 1 - porcentagem/100.0;
        }
    }
}
