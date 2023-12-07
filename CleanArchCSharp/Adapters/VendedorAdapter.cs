using System.Text;
using System.Text.Json;
using FiapCAVendas.Entities;

namespace FiapCAVendas.Adapters
{
    public class VendedorDataAdapter {
        public required string Nome {  get; set; }
        public required string Identificacao {  get; set; }
    }

    class VendedorAdapter
    {
        public static string ToJson(VendedorEntity vendedorEntity)
        {
            var vendedorAdaptedData = new VendedorDataAdapter
            {
                Nome = vendedorEntity.Nome,
                Identificacao = vendedorEntity.Identificacao
            };

            return JsonSerializer.Serialize<VendedorDataAdapter>(vendedorAdaptedData);

        }

    }
}
