using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Persistance.Repositories.Interfaces
{
    public interface IAcademyIncome1CBGURepository
    {
        IQueryable<AcademyIncome1CBGU> GetAcademyIncome1CBGUs();

        //IQueryable<AcademyIncome1CBGU> GetAcademyIncome1CBGUs(string AcademyСategory);

        AcademyIncome1CBGU GetAcademyIncome1CBGU(int id);
        Task<IReadOnlyDictionary<int, AcademyIncome1CBGU>> GetAcademyIncome1CBGUsAsync(
          IReadOnlyCollection<int> academyIncome1CBGUIds,
          CancellationToken cancellationToken);
    }
}
