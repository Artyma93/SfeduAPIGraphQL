using Data.Context;
using Domain.Models;
using Persistance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class AcademyIncome1CBGUDataLoaderRepository : IAcademyIncome1CBGUDataLoaderRepository
    {
        public SfeduMsSqlContext _context { get; }
        public AcademyIncome1CBGUDataLoaderRepository(SfeduMsSqlContext context)
        {
            _context = context;
        }

        public Task<IReadOnlyList<AcademyIncome1CBGU>> GetAcademyIncome1CBGUsDataLoader(IReadOnlyList<string> keys)
        {
            throw new NotImplementedException();
        }

        IReadOnlyList<AcademyIncome1CBGU> IAcademyIncome1CBGUDataLoaderRepository.GetAcademyIncome1CBGUsDataLoader(IReadOnlyList<string> keys)
        {
            throw new NotImplementedException();
        }
    }
}
