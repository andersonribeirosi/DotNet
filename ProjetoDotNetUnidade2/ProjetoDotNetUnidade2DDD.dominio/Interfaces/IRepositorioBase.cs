using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDotNetUnidade2DDD.dominio.Interfaces
{
    public interface IRepositorioBase<TEntidade> where TEntidade : class
    {

        TEntidade GetById(int id);

        IEnumerable<TEntidade> GetAll();

        void Add(TEntidade obj);

        void Update(TEntidade obj);

        void Remove(TEntidade obj);

        void Disponse();
    }
}
