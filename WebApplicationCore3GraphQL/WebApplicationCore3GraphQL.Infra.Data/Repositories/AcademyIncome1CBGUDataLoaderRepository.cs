using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationCore3GraphQL.Infra.Data.Context;
using WebApplicationCore3GraphQL.Infra.Data.Models;
using WebApplicationCore3GraphQL.Infra.Data.Repositories.Interfaces;

namespace WebApplicationCore3GraphQL.Infra.Data.Repositories
{
    public class AcademyIncome1CBGUDataLoaderRepository : IAcademyIncome1CBGUDataLoaderRepository
    {
        public SfeduMsSqlContext _context { get; }
        public AcademyIncome1CBGUDataLoaderRepository(SfeduMsSqlContext context)
        {
            _context = context;
        }

        public IReadOnlyList<AcademyIncome1CBGU> GetAcademy(IReadOnlyList<string> keys)
        {
            throw new NotImplementedException();
        }

        //public Task<IReadOnlyList<AcademyIncome1CBGU>> GetAcademyIncome1CBGUsDataLoader(IReadOnlyList<string> keys)
        //{
        //    throw new NotImplementedException();
        //    //return _context.AcademyIncome1CBGUs;
        //}

        //IReadOnlyList<AcademyIncome1CBGU> IAcademyIncome1CBGUDataLoaderRepository.GetAcademyIncome1CBGUsDataLoader(IReadOnlyList<string> keys)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task<IReadOnlyDictionary<string, AcademyIncome1CBGU>> GetAcademyIncome1CBGUsDataLoader(
        //  IReadOnlyCollection<string> academyIncome1CBGUIds,
        //  CancellationToken cancellationToken)
        //{
        //    List<AcademyIncome1CBGU> posts = await _context.AcademyIncome1CBGUs.Where(c => academyIncome1CBGUIds.Contains(c.AcademyСategory)).ToListAsync();
        //    return posts.ToDictionary(t => t.AcademyСategory);
        //}

        //public IReadOnlyList<AcademyIncome1CBGU> GetAcademy(IReadOnlyList<string> keys)
        //{
        //    //return this.GetUsers(x => keys.Contains(x.AcademyСategory.ToString())).Select(x => x).ToList();
        //    return this.GetUsers(x => keys.Contains(x.AcademyСategory.ToString())).Select(x => x).ToList();
        //}

        //public IQueryable<AcademyIncome1CBGU> GetUsers(Expression<Func<AcademyIncome1CBGU, bool>> expression)
        //{
        //    //var mappedExpression = MappingExtensions.Mapper.Map<Expression<Func<AcademyIncome1CBGUDto, bool>>>(expression);
        //    //return _context.AcademyIncome1CBGUs.Where(mappedExpression).Select(x => x.ToModel());

        //    var mappedExpression = MappingExtensions.Mapper.Map<Expression<Func<AcademyIncome1CBGU, bool>>>(expression);
        //    return _context.AcademyIncome1CBGUs.Where(mappedExpression).Select(x => x.ToModel());
        //}
    }
}
