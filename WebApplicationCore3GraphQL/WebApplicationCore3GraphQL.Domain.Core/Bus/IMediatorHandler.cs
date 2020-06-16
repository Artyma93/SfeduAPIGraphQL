using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApplicationCore3GraphQL.Domain.Core.Commands;
using WebApplicationCore3GraphQL.Domain.Core.Events;

namespace WebApplicationCore3GraphQL.Domain.Core.Bus
{
    interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
        Task RaiseEvent<T>(T @event) where T : Event;
    }
}
