using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationCore3GraphQL.Domain.Core.Events;

namespace WebApplicationCore3GraphQL.Domain.Events
{
    public class CustomerRemovedEvent : Event
    {
        public CustomerRemovedEvent(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; set; }
    }
}
