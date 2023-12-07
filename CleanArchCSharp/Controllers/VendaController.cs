using FiapCAVendas.DAOs;
using FiapCAVendas.Entities;
using FiapCAVendas.Interfaces;
using FiapCAVendas.UseCases;
using FiapCAVendas.Gateway;
using FiapCAVendas.Adapters;

namespace FiapCAVendas.Controllers
{
    internal class VendaController
    {
        internal string RegistrarVenda(VendedorDAO vendedorDAO, List<ProdutoDAO> produtoListDAO, IDatabaseClient databaseClient)
        {
            // quem chama esta passando apenas os dados!
            IVendedorGateway vendedorGateway = new VendedorGateway(databaseClient);
            IVendaGateway vendaGateway = new VendaGateway(databaseClient);
            IProdutoGateway produtoGateway = new ProdutoGateway(databaseClient);

            var vendedor = vendedorGateway.ObterPorIdentificacao(identificacao: vendedorDAO.Identificacao);
            List<ProdutoEntity> produtosVenda = new List<ProdutoEntity>();
            
            foreach (ProdutoDAO produtoDAO in produtoListDAO)
            {
                var produto = produtoGateway.ObterPorIdentificacao(produtoDAO.Identificacao);

                if (produtoDAO.Desconto != null)
                    produto.DefinirDesconto(produtoDAO.Desconto.Value);  
                produtosVenda.Add(produto);
            }

            var registrarVendaUseCase = new RegistrarVendaUseCase(vendedor, produtosVenda);
            var venda = registrarVendaUseCase.FinalizarVenda();
            vendaGateway.RegistrarVenda(venda);

            return VendaAdapter.ToJson(venda);
        }

    }
}
