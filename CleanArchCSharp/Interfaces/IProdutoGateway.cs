using FiapCAVendas.Entities;
using FiapCAVendas.Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapCAVendas.Interfaces
{
    internal interface IProdutoGateway
    {
        public ProdutoEntity ObterPorIdentificacao(string nome);
    }
}
