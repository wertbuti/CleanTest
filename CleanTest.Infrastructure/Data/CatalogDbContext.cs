using CleanTest.Core.BrandAggregate;
using CleanTest.Core.CatalogAggregate;
using CleanTest.Core.CatalogTypeAggregate;
using CleanTest.SharedKernel;
using CleanTest.SharedKernel.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CleanTest.Infrastructure.Data
{
    public class CatalogDbContext : DbContext
    {
        private readonly IDomainEventDispatcher _dispatcher;

        public CatalogDbContext(DbContextOptions<CatalogDbContext> options,
            IDomainEventDispatcher dispatcher) : base(options)
        {
            _dispatcher = dispatcher;
        }

        public DbSet<Catalog> Catalog => Set<Catalog>();
        public DbSet<CatalogBrand> CatalogBrands => Set<CatalogBrand>();

        public DbSet<CatalogType> CatalogTypes => Set<CatalogType>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

            // ignore events if no dispatcher provided
            if (_dispatcher == null) return result;

            // dispatch events only if save was successful
            var entitiesWithEvents = ChangeTracker.Entries<EntityBase>()
                .Select(e => e.Entity)
                .Where(e => e.DomainEvents.Any())
                .ToArray();

            await _dispatcher.DispatchAndClearEvents(entitiesWithEvents);

            return result;
        }

        public override int SaveChanges()
        {
            return SaveChangesAsync().GetAwaiter().GetResult();
        }

    }
}
