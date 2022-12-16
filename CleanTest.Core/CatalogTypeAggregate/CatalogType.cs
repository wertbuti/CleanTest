using CleanTest.SharedKernel;
using CleanTest.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTest.Core.CatalogTypeAggregate
{
    public class CatalogType : EntityBase , IAggregateRoot
    {
        public string Type { get; private set; }

        public CatalogType(string type)
        {
            Type = type;
        }
        
    }
}
