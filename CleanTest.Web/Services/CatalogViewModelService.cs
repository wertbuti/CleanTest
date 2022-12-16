using AutoMapper;
using CleanTest.Core.BrandAggregate;
using CleanTest.Core.CatalogAggregate;
using CleanTest.Core.CatalogAggregate.Specifications;
using CleanTest.Core.CatalogTypeAggregate;
using CleanTest.Core.Interfaces;
using CleanTest.SharedKernel.Interfaces;
using CleanTest.Web.Areas.CatalogArea.ViewModels;
using CleanTest.Web.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CleanTest.Web.Services
{
    public class CatalogViewModelService : ICatalogViewModelService
    {
        private readonly IReadRepository<Catalog> _catalogRepository;
        public readonly IReadRepository<CatalogType> _typeRepository;
        private readonly IReadRepository<CatalogBrand> _brandRepository;
        private readonly IMapper _mapper;
        private readonly IUriComposer _uriComposer;

        public CatalogViewModelService(IReadRepository<Catalog> catalogRepository,
            IReadRepository<CatalogType> typeRepository,
            IReadRepository<CatalogBrand> brandRepository,
            IMapper mapper,
            IUriComposer uriComposer)
        {
            _catalogRepository = catalogRepository;
            _typeRepository = typeRepository;
            _brandRepository = brandRepository;
            _mapper = mapper;
            _uriComposer = uriComposer;
        }

        public async Task<CatalogIndexViewModel> GetCatalogs()
        {
            var filterSpecification = new CatalogFilterSpecification(2, 2);

            var catalogs = await _catalogRepository.ListAsync(filterSpecification);

            //1
            var catalogIndexViewModels = new CatalogIndexViewModel
            {
                Catalogs = catalogs.Select(i => new CatalogViewModel
                {
                    Description = i.Description,
                    Name = i.Name,
                    PictureUri = _uriComposer.ComposePicUri(i.PictureUri),
                    Price = i.Price
                }).ToList(),
                Types = (await GetTypes()).ToList(),
                Brands = (await GetBrands()).ToList(),

            };
            //2
            //var catalogViewModels = _mapper.Map<List<CatalogViewModel>>(catalogs);


            return catalogIndexViewModels;
        }


        public async Task<IEnumerable<SelectListItem>> GetTypes()
        {
            var types = await _typeRepository.ListAsync();

            var items = types
                .Select(i => new SelectListItem { Value = i.Id.ToString(),Text = i.Type })
                .OrderBy(i=>i.Text)
                .ToList();

            var allItem = new SelectListItem { Value = null, Text = "All", Selected = true };
            items.Insert(0, allItem);

            return items;
        }

        public async Task<IEnumerable<SelectListItem>> GetBrands()
        {
            var brands = await _brandRepository.ListAsync();

            var items = brands
                .Select(i => new SelectListItem { Value = i.Id.ToString(), Text = i.Brand})
                .OrderBy(i=>i.Text)
                .ToList();
                
            var AllItem = new SelectListItem { Value= null, Text ="All",Selected = true };

            items.Insert(0, AllItem);
            return items;
        
        }

    }
}
