using FiapCAVendas.Entities;

namespace FiapCAVendas.UseCases
{
    internal class RegistrarVendaUseCase
    {
        private Venda Venda;
        private readonly List<ProdutoEntity> listaProdutos;

        public RegistrarVendaUseCase(VendedorEntity vendedor, List<ProdutoEntity> listaProdutos)
        {
            Venda = new Venda(vendedor);
            this.listaProdutos = listaProdutos;
        }

        public Venda FinalizarVenda()
        {
            foreach (ProdutoEntity produto in listaProdutos)
            {
                if (produto.Preco <= 10)
                    throw new Exception("Valor de produto muito baixo");
                Venda.AdicionarProduto(produto);
            }

            if (Venda.TotalVenda <= 0)
                throw new Exception("Valor de venda inválido");
            if (Venda.TotalVenda == 0 && Venda.Itens.Count < 1)
            {
                throw new Exception("Total de itens inválido");
            }

            return Venda;
        }
    }
}
