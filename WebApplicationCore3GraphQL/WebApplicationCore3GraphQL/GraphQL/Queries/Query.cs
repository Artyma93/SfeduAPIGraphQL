using Domain.Models;
using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistance.Repositories.Interfaces;
using System.Threading;

namespace WebApplicationCore3GraphQL.GraphQL.Queries
{
    public class Query
    {
        public IQueryable<Academy1CBGU> GetAcademy1CBGUs([Service]IAcademy1CBGURepository repository)
        {
            return repository.GetAcademy1CBGUs();
        }

        //public IQueryable<AcademyIncome1CBGU> GetAcademyIncome1CBGUs([Service]IAcademyIncome1CBGURepository repository, string AcademyСategory)
        //{
        //    return repository.GetAcademyIncome1CBGUs(AcademyСategory);
        //}

        public IQueryable<AcademyIncome1CBGU> GetAcademyIncome1CBGUs([Service]IAcademyIncome1CBGURepository repository)
        {
            return repository.GetAcademyIncome1CBGUs();
        }

        public AcademyIncome1CBGU GetAcademyIncome1CBGU([Service]IAcademyIncome1CBGURepository repository, int id)
        {
            return repository.GetAcademyIncome1CBGU(id);
        }

        public async Task<IReadOnlyDictionary<int, AcademyIncome1CBGU>> GetAcademyIncome1CBGUsAsync(
            [Service]IAcademyIncome1CBGURepository repository,
            IReadOnlyCollection<int> academyIncome1CBGUIds,
            CancellationToken cancellationToken)
        {
            return await repository.GetAcademyIncome1CBGUsAsync(academyIncome1CBGUIds, cancellationToken);
        }
    }
}
