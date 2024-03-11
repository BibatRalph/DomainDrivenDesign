using DomainDrivenDesign.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDrivenDesign.HelperMethods
{
    public abstract class Entity
    {
        private readonly List<IDomainEvents> _events = new();
        public IEnumerable<IDomainEvents> DomainEvents => _events.ToList();

        protected void RaiseEvent(IDomainEvents domainEvent)
        {
            _events.Add(domainEvent);
        }

        protected Entity(Guid id) => Id = id;
        public Guid Id { get; init; }
    }
}
