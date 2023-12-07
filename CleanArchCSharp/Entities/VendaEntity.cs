namespace FiapCAVendas.Entities
{
    internal class VendaEntity
    {
       
        public DateTime Data { get; }
        public List<ProdutoEntity> Itens { get; }
        public VendedorEntity Vendedor { get; }

        public VendaEntity(VendedorEntity vendedor)
        {
            this.Data = DateTime.Now;
            this.Itens = new List<ProdutoEntity>();
            this.Vendedor = vendedor;
        }

        public void AdicionarProduto(ProdutoEntity produto)
        {
            this.Itens.Add(produto);
        }

        public double TotalVenda
        {
            get
            {
                double total = 0;
                foreach (ProdutoEntity produto in this.Itens)
                {
                    total += produto.Preco;
                }
                return total;
            }
        }
    }
}
