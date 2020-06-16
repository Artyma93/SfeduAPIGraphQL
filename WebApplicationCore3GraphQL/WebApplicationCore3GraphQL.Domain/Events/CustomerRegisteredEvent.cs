using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationCore3GraphQL.Domain.Core.Events;

namespace WebApplicationCore3GraphQL.Domain.Events
{
    public class CustomerRegisteredEvent : Event
    {
        public CustomerRegisteredEvent(Guid id, string name, string email, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            AggregateId = id;
        }
        public Guid Id { get; set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public DateTime BirthDate { get; private set; }
    }
}
