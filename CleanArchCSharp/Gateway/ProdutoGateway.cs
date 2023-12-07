using FiapCAVendas.Entities;
using FiapCAVendas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapCAVendas.Gateway
{
    internal class ProdutoGateway : IProdutoGateway
    {
        public IDatabaseClient DatabaseClient { get; }
        public ProdutoGateway(IDatabaseClient databaseClient)
        {
            DatabaseClient = databaseClient;
        }

        public ProdutoEntity ObterPorIdentificacao(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
