using ProjetoDotNetUnidade2DDD.Aplicacao.Interface;
using ProjetoDotNetUnidade2DDD.dominio.Interfaces.Serviços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDotNetUnidade2DDD.Aplicacao
{
      public class AppServicoBase<TEntidade> : IDisposable, IAppServicoBase<TEntidade> where TEntidade : class
    {
        private readonly IServicoBase<TEntidade> _servicoBase;

        public AppServicoBase(IServicoBase<TEntidade> servicoBase)
        {
            _servicoBase = servicoBase;
        }

        public void Add(TEntidade obj)
        {
            _servicoBase.Add(obj);
        }

        public void Dispose()
        {
            _servicoBase.Disponse();
        }

        public IEnumerable<TEntidade> GetAll()
        {
            return _servicoBase.GetAll();
        }

        public TEntidade GetById(int id)
        {
            return _servicoBase.GetById(id);
        }

        public void Remove(TEntidade obj)
        {
            _servicoBase.Remove(obj);
        }

        public void Update(TEntidade obj)
        {
            _servicoBase.Update(obj);
        }
    }
}
