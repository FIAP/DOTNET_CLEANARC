using FiapCAVendas.Entities;
using FiapCAVendas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapCAVendas.Gateway
{
    internal class VendedorGateway : IVendedorGateway
    {
        readonly IDatabaseClient DatabaseClient;
        
        public VendedorGateway(IDatabaseClient databaseClient) 
        {
            DatabaseClient = databaseClient;
        }
        public VendedorEntity ObterPorIdentificacao(string identificacao)
        {
            throw new NotImplementedException();
        }
    }
}
