using System.Collections.Generic;

// Classe genérica de serviços (base)
namespace ProjetoDotNetUnidade2DDD.dominio.Interfaces.Serviços
{
    public interface IServicoBase<TEntidade> where TEntidade : class
    {
        TEntidade GetById(int id);

        IEnumerable<TEntidade> GetAll();

        void Add(TEntidade obj);

        void Update(TEntidade obj);

        void Remove(TEntidade obj);

        void Disponse();
    }
}
