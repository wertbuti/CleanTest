using CleanTest.Core.CatalogAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTest.Core.Interfaces
{
    public interface IUriComposer
    { 
        public string ComposePicUri(string uriTemplate);
        
    }
}
