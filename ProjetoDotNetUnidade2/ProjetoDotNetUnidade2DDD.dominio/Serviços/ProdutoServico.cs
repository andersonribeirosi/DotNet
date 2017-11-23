using ProjetoDotNetUnidade2DDD.dominio.Entidades;
using ProjetoDotNetUnidade2DDD.dominio.Interfaces;
using ProjetoDotNetUnidade2DDD.dominio.Interfaces.Serviços;
using System;
using System.Collections.Generic;

namespace ProjetoDotNetUnidade2DDD.dominio.Serviços
{
    public class ProdutoServico : ServicoBase<Produto>, IProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoServico(IProdutoRepositorio produtoRepositorio)
            : base(produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepositorio.BuscarPorNome(nome);
        }
    }
}
