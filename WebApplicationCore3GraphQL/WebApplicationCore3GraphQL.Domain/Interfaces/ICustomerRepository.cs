using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationCore3GraphQL.Domain.Models;

namespace WebApplicationCore3GraphQL.Domain.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer GetByEmail(string email);
    }
}
