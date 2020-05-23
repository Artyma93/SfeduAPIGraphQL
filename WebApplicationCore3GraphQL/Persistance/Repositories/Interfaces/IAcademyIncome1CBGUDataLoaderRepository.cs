using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Persistance.Repositories.Interfaces
{
    public interface IAcademyIncome1CBGUDataLoaderRepository
    {
        //Task<IReadOnlyDictionary<string, AcademyIncome1CBGU>> GetAcademyIncome1CBGUsDataLoader(
        //    IReadOnlyCollection<string> academyIncome1CBGUIds,
        //    CancellationToken cancellationToken);

        IReadOnlyList<AcademyIncome1CBGU> GetAcademy(IReadOnlyList<string> keys);
    }
}
