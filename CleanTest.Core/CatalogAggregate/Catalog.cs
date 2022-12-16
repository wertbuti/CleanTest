using CleanTest.Core.BrandAggregate;
using CleanTest.Core.CatalogTypeAggregate;
using CleanTest.SharedKernel;
using CleanTest.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTest.Core.CatalogAggregate
{
    public class Catalog : EntityBase, IAggregateRoot
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public string PictureUri { get; private set; }
        public int CatalogTypeId { get; private set; }
        //public CatalogType? CatalogType { get; private set; }
        public int CatalogBrandId { get; private set; }
                   
        //public CatalogBrand? CatalogBrand { get; private set; }

        public Catalog(string name, 
            string description, 
            decimal price, 
            string pictureUri,
            int catalogTypeId,
            int catalogBrandId)
        {
            Name = name;
            Description = description;
            Price = price;
            PictureUri = pictureUri;
            CatalogTypeId = catalogTypeId;
            CatalogBrandId = catalogBrandId;
        }
    }
}
