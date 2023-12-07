using System.Reflection.Metadata;

namespace FiapCAVendas.Entities
{
    internal class VendedorEntity
    {
        public string Nome { get;  }
        public string Identificacao { get; } 

        public VendedorEntity(string nome, string identificacao)
        {
            if (string.IsNullOrEmpty(nome))
                throw new System.ArgumentException("O nome não pode ser nulo ou vazio", nameof(nome));
            if (string.IsNullOrEmpty(identificacao))
                throw new System.ArgumentException("A identificacao não pode ser nulo ou vazio", nameof(identificacao));

            this.Nome = nome;
            this.Identificacao = identificacao;
        }
    }
}
