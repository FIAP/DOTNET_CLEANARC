using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapCAVendas.Entities
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Identificacao { get; set; }

        public Pessoa(string nome, string identificacao)
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
