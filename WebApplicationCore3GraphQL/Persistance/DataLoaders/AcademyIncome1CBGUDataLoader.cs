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
    public class AcademyIncome1CBGUDataLoader : DataLoaderBase<string, AcademyIncome1CBGU>
    {
        private readonly IAcademyIncome1CBGUDataLoaderRepository _repository;

        public AcademyIncome1CBGUDataLoader(IAcademyIncome1CBGUDataLoaderRepository repository)
          : base(new DataLoaderOptions<string>())
        {
            _repository = repository;
        }

        protected override Task<IReadOnlyList<Result<AcademyIncome1CBGU>>> FetchAsync(
            IReadOnlyList<string> keys, 
            CancellationToken cancellationToken)
        {
            return _repository.GetAcademy(keys).Select(x => x).ToList();
        }

        //protected override Task<IReadOnlyList<Result<AcademyIncome1CBGU>>> FetchAsync(
        //    IReadOnlyList<string> keys, 
        //    CancellationToken cancellationToken)
        //{
        //    return _repository.GetAcademyIncome1CBGUsDataLoader(keys, cancellationToken);
        //}

        #region //v1
        //protected override Task<IReadOnlyList<Result<AcademyIncome1CBGU>>> FetchAsync(
        //    IReadOnlyList<string> keys, 
        //    CancellationToken cancellationToken)
        //{
        //    // v 1
        //    //await Task.Yield();
        //    //return _repository.GetAcademyIncome1CBGUsDataLoader(keys).Select(x => Result<UserDto>.Resolve(x.ToTransport())).ToList();

        //    // v 2
        //    //return await Task.FromResult<IReadOnlyList<Result<AcademyIncome1CBGU>>>(
        //    //    keys.Select(t => (Result<AcademyIncome1CBGU>)t).ToArray());

        //    // v 3
        //    //return await _repository.GetAcademyIncome1CBGUsDataLoader(keys).Select(x => Result<UserDto>.Resolve(x.ToTransport())).ToList();

        //    // v 4
        //    //return await _repository.GetAcademyIncome1CBGUsDataLoader(keys).Select(AcademyIncome1CBGU).ToList();

        //    // v 5
        //    return _repository.GetAcademyIncome1CBGUsDataLoader(keys);
        //}

        #endregion

    }
}
