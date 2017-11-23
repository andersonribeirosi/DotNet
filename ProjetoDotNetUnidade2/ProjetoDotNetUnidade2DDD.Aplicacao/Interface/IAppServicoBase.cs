using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDotNetUnidade2DDD.Aplicacao.Interface
{
    public interface IAppServicoBase<TEntidade> where TEntidade : class
    {
        void Add(TEntidade obj);

        TEntidade GetById(int id);

        IEnumerable<TEntidade> GetAll();

        void Update(TEntidade obj);

        void Remove(TEntidade obj);

        void Dispose();
    }
}
