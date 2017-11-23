using ProjetoDotNetUnidade2DDD.Aplicacao.Interface;
using ProjetoDotNetUnidade2DDD.dominio.Entidades;
using ProjetoDotNetUnidade2DDD.dominio.Interfaces.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDotNetUnidade2DDD.Aplicacao
{
    public class ClienteAppServico : AppServicoBase<Cliente>, IClienteAppServico
    {
        private readonly IClienteServico _clienteServico;

        public ClienteAppServico(IClienteServico clienteServico)
            : base(clienteServico)
        {
            _clienteServico = clienteServico;
        }
        
        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            return _clienteServico.ObterClienteEspeciais(_clienteServico.GetAll());
        }
    }
}
