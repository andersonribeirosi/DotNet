namespace ProjetoDotNetUnidade2.Infra.Data.Contexto
{
    using ProjetoDotNetUnidade2DDD.dominio.Entidades;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System;

    public class Context : DbContext
    {
        public Context()
            : base("name=ProjetoDotNetUnidade2")
        {
        }
        
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        internal void SaveChanges<TEntidade>(TEntidade obj) where TEntidade : class
        {
            throw new NotImplementedException();
        }
    }
}