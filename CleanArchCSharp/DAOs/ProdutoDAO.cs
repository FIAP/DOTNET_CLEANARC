using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapCAVendas.DAOs
{
    internal class ProdutoDAO
    {
        public required string Nome {  get; set; }
        public required string Identificacao { get; set; }
        public required double Preco {  get; set; }
        public double? Desconto {  get; set; }
    }
}
