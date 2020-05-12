using Domain.Models;
using GreenDonut;
using Persistance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebApplicationCore3GraphQL.Persistance.DataLoaders
{
    public class AcademyIncome1CBGUDataLoader : DataLoaderBase<int, AcademyIncome1CBGU>
    {
        private readonly IAcademyIncome1CBGURepository _repository;

        public AcademyIncome1CBGUDataLoader(IAcademyIncome1CBGURepository repository)
          : base(new DataLoaderOptions<int>())
        {
            _repository = repository;
        }

        protected override Task<IReadOnlyList<Result<AcademyIncome1CBGU>>> FetchAsync(IReadOnlyList<int> keys, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        //protected override Task<IReadOnlyList<Result<AcademyIncome1CBGU>>> FetchAsync(IReadOnlyList<int> keys, CancellationToken cancellationToken)
        //{
        //    return _repository.GetAcademyIncome1CBGU(keys);
        //}

    }
}
