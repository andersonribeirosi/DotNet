using ProjetoDotNetUnidade2DDD.dominio.Entidades;
using System.Collections.Generic;

namespace ProjetoDotNetUnidade2DDD.dominio.Interfaces.Serviços
{
    public interface IClienteServico : IServicoBase<Cliente>
    {
        IEnumerable<Cliente> ObterClienteEspeciais(IEnumerable<Cliente> clientes);
    }
}
