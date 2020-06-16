using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationCore3GraphQL.Domain.Commands;

namespace WebApplicationCore3GraphQL.Domain.Validations
{
    public class UpdateCustomerCommandValidation : CustomerValidation<UpdateCustomerCommand>
    {
        public UpdateCustomerCommandValidation()
        {
            ValidateId();
            ValidateName();
            ValidateBirthDate();
            ValidateEmail();
        }
    }
}
