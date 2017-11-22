using ProjetoDotNetUnidade2DDD.dominio.Entidades;
using System.Collections.Generic;

namespace ProjetoDotNetUnidade2DDD.dominio.Interfaces.Serviços
{
    public interface IProdutoServico : IServicoBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
