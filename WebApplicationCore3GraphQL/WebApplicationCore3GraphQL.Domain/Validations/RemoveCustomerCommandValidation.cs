using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationCore3GraphQL.Domain.Commands;

namespace WebApplicationCore3GraphQL.Domain.Validations
{
    public class RemoveCustomerCommandValidation : CustomerValidation<RemoveCustomerCommand>
    {
        public RemoveCustomerCommandValidation()
        {
            ValidateId();
        }
    }
}
