using FiapCAVendas.Entities;

namespace FiapCAVendas.Interfaces
{
    internal interface IVendedorGateway
    {
        public VendedorEntity ObterPorIdentificacao(string identificacao);
    }
}