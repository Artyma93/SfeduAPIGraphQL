using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationCore3GraphQL.Domain.Core.Events;

namespace WebApplicationCore3GraphQL.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }

        public abstract bool IsValid();
    }
