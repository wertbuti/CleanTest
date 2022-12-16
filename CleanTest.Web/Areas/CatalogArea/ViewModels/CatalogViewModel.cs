using CleanTest.Core.CatalogTypeAggregate;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CleanTest.Web.Areas.CatalogArea.ViewModels
{
    public class CatalogViewModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? PictureUri { get; set; }
     }
}
