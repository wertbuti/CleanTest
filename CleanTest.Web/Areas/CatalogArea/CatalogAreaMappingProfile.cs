using AutoMapper;
using CleanTest.Core.CatalogAggregate;
using CleanTest.Web.Areas.CatalogArea.ViewModels;

namespace CleanTest.Web.Areas.CatalogArea
{
    public class CatalogAreaMappingProfile : Profile
    {
        public CatalogAreaMappingProfile()
        {
            CreateMap<Catalog, CatalogViewModel>();
            //CreateMap<ArticleInputVM, ArticleVM>();
        }
    }
}
