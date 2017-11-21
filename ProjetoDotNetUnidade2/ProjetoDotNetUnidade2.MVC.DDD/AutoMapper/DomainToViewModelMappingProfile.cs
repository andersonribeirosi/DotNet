using AutoMapper;
using ProjetoDotNetUnidade2.MVC.DDD.ViewModels;
using ProjetoDotNetUnidade2DDD.dominio.Entidades;

namespace ProjetoDotNetUnidade2.MVC.DDD.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
        }
    }
}