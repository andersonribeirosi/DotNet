using ProjetoDotNetUnidade2.Infra.Data.Contexto;
using ProjetoDotNetUnidade2DDD.dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

// Repositório Genérico
namespace ProjetoDotNetUnidade2.Infra.Data.Repositorios
{
    public class RepositorioBase<TEntidade> : IDisposable, IRepositorioBase<TEntidade> where TEntidade : class
    {

        protected Context Db = new Context();

        public IEnumerable<TEntidade> GetAll()
        {
          return  Db.Set<TEntidade>().ToList();
        }

        public TEntidade GetById(int id)
        {
           return Db.Set<TEntidade>().Find(id);
         
        }

        public void Add(TEntidade obj)
        {
            Db.Set<TEntidade>().Add(obj);
            // Salvar as alterações
            Db.SaveChanges();
        }

        public void Remove(TEntidade obj)
        {
            Db.Set<TEntidade>().Remove(obj);
            Db.SaveChanges();
        }

        public void Update(TEntidade obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Disponse()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
