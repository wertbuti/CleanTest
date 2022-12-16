using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanTest.SharedKernel
{
    public abstract class EntityBase
    {
        public int Id { get; set; }

        private List<DomainEventBase> _domainEvents = new();

        [NotMapped]
        public IEnumerable<DomainEventBase> DomainEvents => _domainEvents.AsReadOnly();

        protected void RegisterDomainEvent(DomainEventBase domainEvent) => _domainEvents.Add(domainEvent);

        internal void ClearDomainEvents() => _domainEvents.Clear();
    }
}
