using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTest.Core.CatalogAggregate.Specifications
{
    public class CatalogFilterSpecification : Specification<Catalog>
    {
        public CatalogFilterSpecification(int? typeId, int? brandId)
        {
            Query.Where(i => (!typeId.HasValue || i.CatalogTypeId == typeId) &&
            (!brandId.HasValue || i.CatalogBrandId == brandId));
        }
    }
}
