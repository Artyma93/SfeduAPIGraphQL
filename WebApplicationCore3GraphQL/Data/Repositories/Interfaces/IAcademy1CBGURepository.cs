using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebApplicationCore3GraphQL.Infra.Data.Models;

namespace WebApplicationCore3GraphQL.Infra.Data.Repositories.Interfaces
{
    public interface IAcademy1CBGURepository
    {
        IQueryable<Academy1CBGU> GetAcademy1CBGUs();
        //Academy1CBGU GetAcademy1CBGU(Guid id);
        //Task<IReadOnlyDictionary<Guid, Academy1CBGU>> GetAcademy1CBGUsAsync(
        //  IReadOnlyCollection<Guid> userIds,
        //  CancellationToken cancellationToken);

        Academy1CBGU GetAcademy1CBGU(int id);
        Task<IReadOnlyDictionary<int, Academy1CBGU>> GetAcademy1CBGUsAsync(
          IReadOnlyCollection<int> academy1CBGUIds,
          CancellationToken cancellationToken);
    }
}
