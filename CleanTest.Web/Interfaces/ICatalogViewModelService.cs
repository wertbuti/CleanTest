using CleanTest.Web.Areas.CatalogArea.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CleanTest.Web.Interfaces
{
    public interface ICatalogViewModelService
    {
        Task<CatalogIndexViewModel> GetCatalogs();
        Task<IEnumerable<SelectListItem>> GetBrands();
        Task<IEnumerable<SelectListItem>> GetTypes();
    }
}
