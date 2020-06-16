﻿using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationCore3GraphQL.Domain.Commands;

namespace WebApplicationCore3GraphQL.Domain.Validations
{
    public class RegisterNewCustomerCommandValidation : CustomerValidation<RegisterNewCustomerCommand>
    {
        public RegisterNewCustomerCommandValidation()
        {
            ValidateName();
            ValidateBirthDate();
            ValidateEmail();
        }
    }
}
