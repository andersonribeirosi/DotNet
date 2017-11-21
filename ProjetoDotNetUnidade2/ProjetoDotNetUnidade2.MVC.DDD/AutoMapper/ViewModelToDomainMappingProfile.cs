using AutoMapper;
using ProjetoDotNetUnidade2.MVC.DDD.ViewModels;
using ProjetoDotNetUnidade2DDD.dominio.Entidades;

// Classe que transforma o ViewModel em Domínio
namespace ProjetoDotNetUnidade2.MVC.DDD.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
        }
    }
}
