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
    public class ProdutoAppServico : AppServicoBase<Produto>, IProdutoAppServico
    {
        private readonly IProdutoServico _produtoServico;

        public ProdutoAppServico(IProdutoServico produtoServico)
            : base(produtoServico)
        {
            _produtoServico = produtoServico;
        }


        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoServico.BuscarPorNome(nome);
        }
    }
}
