using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiapCAVendas.Entities;

namespace FiapCAVendas.Interfaces
{
    internal interface IDatabaseClient
    {

        void IncluirVenda(VendaEntity venda);
    }
}
