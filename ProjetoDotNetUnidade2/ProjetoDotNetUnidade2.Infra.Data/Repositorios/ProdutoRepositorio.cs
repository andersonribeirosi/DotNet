using ProjetoDotNetUnidade2DDD.dominio.Entidades;
using ProjetoDotNetUnidade2DDD.dominio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoDotNetUnidade2.Infra.Data.Repositorios
{
    public class ProdutoRepositorio : RepositorioBase<Produto>, IProdutoRepositorio
    {

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
