using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationCore3GraphQL.Infra.Data.Models;

namespace WebApplicationCore3GraphQL.Infra.Data.Repositories.Interfaces
{
    public interface IAcademyIncome1CBGUDataLoaderRepository
    {
        //Task<IReadOnlyDictionary<string, AcademyIncome1CBGU>> GetAcademyIncome1CBGUsDataLoader(
        //    IReadOnlyCollection<string> academyIncome1CBGUIds,
        //    CancellationToken cancellationToken);

        IReadOnlyList<AcademyIncome1CBGU> GetAcademy(IReadOnlyList<string> keys);
    }
}
