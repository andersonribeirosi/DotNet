using ProjetoDotNetUnidade2DDD.dominio.Entidades;
using ProjetoDotNetUnidade2DDD.dominio.Interfaces;
using ProjetoDotNetUnidade2DDD.dominio.Interfaces.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDotNetUnidade2DDD.dominio.Serviços
{
    public class ClienteServico : ServicoBase<Cliente>, IClienteServico
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteServico(IClienteRepositorio clienteRepositorio)
            : base(clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public IEnumerable<Cliente> ObterClienteEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
