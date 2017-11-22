using ProjetoDotNetUnidade2DDD.dominio.Interfaces.Serviços;
using System;
using System.Collections.Generic;

// O serviço trabalha com o repositório
namespace ProjetoDotNetUnidade2DDD.dominio.Serviços
{
    public class ServicoBase<TEntidade> : IDisposable, IServicoBase<TEntidade> where TEntidade : class
    {
        public void Add(TEntidade obj)
        {
            throw new NotImplementedException();
        }

        public void Disponse()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntidade> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntidade GetNyId(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntidade obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntidade obj)
        {
            throw new NotImplementedException();
        }
    }
}
