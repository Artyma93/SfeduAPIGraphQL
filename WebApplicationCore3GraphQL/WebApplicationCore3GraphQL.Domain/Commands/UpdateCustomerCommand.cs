using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Text;
using WebApplicationCore3GraphQL.Domain.Validations;

namespace WebApplicationCore3GraphQL.Domain.Commands
{
    public class UpdateCustomerCommand : CustomerCommand
    {
        public UpdateCustomerCommand(Guid id, string name, string email, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override bool IsValid()
        {
            ValidationResult = new UpdateCustomerCommandValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
