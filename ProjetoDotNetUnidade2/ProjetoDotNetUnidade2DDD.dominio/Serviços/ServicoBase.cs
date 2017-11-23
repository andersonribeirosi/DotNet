using ProjetoDotNetUnidade2DDD.dominio.Interfaces;
using ProjetoDotNetUnidade2DDD.dominio.Interfaces.Serviços;
using System;
using System.Collections.Generic;

// O serviço trabalha com o repositório
namespace ProjetoDotNetUnidade2DDD.dominio.Serviços
{
    public class ServicoBase<TEntidade> : IDisposable, IServicoBase<TEntidade> where TEntidade : class
    {
        private readonly IRepositorioBase<TEntidade> _repositorio;

        public ServicoBase(IRepositorioBase<TEntidade> repositorio)
        {
            _repositorio = repositorio;
        }


        public void Add(TEntidade obj)
        {
            _repositorio.Add(obj);
        }

        public void Disponse()
        {
            _repositorio.Disponse();
        }

        public void Dispose()
        {
            _repositorio.Disponse();
        }

        public IEnumerable<TEntidade> GetAll()
        {
            return _repositorio.GetAll();
        }

        public TEntidade GetById(int id)
        {
            return _repositorio.GetById(id);
        }

        public void Remove(TEntidade obj)
        {
            _repositorio.Remove(obj);
        }

        public void Update(TEntidade obj)
        {
            _repositorio.Update(obj);
        }
    }
}
