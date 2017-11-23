using ProjetoDotNetUnidade2DDD.dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDotNetUnidade2DDD.Aplicacao.Interface
{
    public interface IClienteAppServico : IAppServicoBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
