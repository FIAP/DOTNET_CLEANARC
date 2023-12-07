using System.Text.Json;
using FiapCAVendas.Entities;

namespace FiapCAVendas.Adapters
{
    public class ProdutoDataAdapter {
        public required string Nome {  get; set; }
        public required string Identificacao {  get; set; }
        public required double Preco { get; set; }
    }

    class ProdutoAdapter
    {
        static public string ToJson(ProdutoEntity produtoEntity)  {
            var produtoAdaptedData = new ProdutoDataAdapter{
                Nome = produtoEntity.Nome,
                Identificacao = produtoEntity.Identificacao,
                Preco = produtoEntity.Preco
            } ;

            return JsonSerializer.Serialize<ProdutoDataAdapter>(produtoAdaptedData);
        }
    }
}
