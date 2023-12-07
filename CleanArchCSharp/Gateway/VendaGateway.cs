using FiapCAVendas.Entities;
using FiapCAVendas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapCAVendas.Gateway
{
    internal class VendaGateway: IVendaGateway
    {
        readonly IDatabaseClient DatabaseClient;
        public VendaGateway(IDatabaseClient databaseClient) {
            DatabaseClient = databaseClient;
        }

        public void RegistrarVenda(VendaEntity venda)
        {
            DatabaseClient.IncluirVenda(venda);
        }
    }
}
