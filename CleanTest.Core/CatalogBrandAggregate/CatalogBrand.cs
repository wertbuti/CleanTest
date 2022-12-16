using CleanTest.SharedKernel;
using CleanTest.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTest.Core.BrandAggregate
{
    public class CatalogBrand : EntityBase , IAggregateRoot
    {
        public string Brand { get; private set; }

        public CatalogBrand(string brand)
        {
            Brand = brand;
        }

    }
}
