using AutoMapper;
using CleanTest.Core.CatalogAggregate;
using CleanTest.SharedKernel.Interfaces;
using CleanTest.Web.Areas.CatalogArea.ViewModels;
using CleanTest.Web.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CleanTest.Web.Areas.CatalogArea.Pages.CatalogPages
{
    public class IndexModel : PageModel
    {
        //IReadRepository<Catalog> _readRepository;
        //private readonly IMapper _mapper;
        private readonly ICatalogViewModelService _catalogViewModelService;

        public IndexModel(/*IReadRepository<Catalog> readRepository,*/
            //IMapper mapper,
            ICatalogViewModelService catalogViewModelService
            )
        {
            //_readRepository = readRepository;
            //_mapper = mapper;
            _catalogViewModelService = catalogViewModelService;
        }

        public CatalogIndexViewModel CatalogIndexModel { get; set; } = new();
        //public void OnGet()
        //{
        //    var catalogs = _readRepository.ListAsync().Result;

        //    CatalogViewModels = _mapper.Map<List<CatalogViewModel>>(catalogs);
        //}

        public async Task<IActionResult> OnGetAsync()
        {
            CatalogIndexModel = await _catalogViewModelService.GetCatalogs();

            return Page();
        }
    }
}
