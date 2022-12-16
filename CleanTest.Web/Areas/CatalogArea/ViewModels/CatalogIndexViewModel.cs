using Microsoft.AspNetCore.Mvc.Rendering;

namespace CleanTest.Web.Areas.CatalogArea.ViewModels
{
    public class CatalogIndexViewModel
    {
        public List<CatalogViewModel>? Catalogs { get; set; }

        public List<SelectListItem>? Types { get; set; }

        public int TypeFilterApplied { get; set; }

        public List<SelectListItem>? Brands { get; set; }

        public int? BrandFilterApplied { get; set; }
    }
}
