using FiapCAVendas.Entities;

namespace FiapCAVendas.Adapters {

    class VendaAdapterData
    { 
        public required string Data { get; set; }
        public required VendedorDataAdapter Vendedor { get; set; }
        public required List<ProdutoDataAdapter> Itens { get; set;  }
    }
    class VendaAdapter 
    {
        static public string ToJson(VendaEntity vendaEntity)
        {
            var vendaAdaptedData = new VendaAdapterData
            {
                Data = vendaEntity.Data.ToString(),
                Vendedor = new VendedorDataAdapter
                {
                    Nome = vendaEntity.Vendedor.Nome,
                    Identificacao = vendaEntity.Vendedor.Identificacao
                },
                Itens = new List<ProdutoDataAdapter>()
            };

            foreach (ProdutoEntity produto in vendaEntity.Itens)
            {
                vendaAdaptedData.Itens.Add(new ProdutoDataAdapter
                {
                    Nome = produto.Nome,
                    Identificacao = produto.Identificacao,
                    Preco = produto.Preco
                });
            }

            return System.Text.Json.JsonSerializer.Serialize<VendaAdapterData>(vendaAdaptedData);

        }        

    }
}
