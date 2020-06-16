using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplicationCore3GraphQL.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
