using Ardalis.Specification.EntityFrameworkCore;
using CleanTest.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTest.Infrastructure.Data
{
    public class EfRepository<T> : RepositoryBase<T> , IRepository<T>, IReadRepository<T> where T : class,IAggregateRoot
    {
        public EfRepository(CatalogDbContext dbContext) : base(dbContext)
        { 
        }
    }
}
