using Data.Context;
using Domain.Models;
using HotChocolate;
using Microsoft.EntityFrameworkCore;
using Persistance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebApplicationCore3GraphQL.Persistance.DataLoaders;

namespace Persistance.Repositories
{
    public class AcademyIncome1CBGURepository : IAcademyIncome1CBGURepository
    {
        public SfeduMsSqlContext _context { get; }
        public AcademyIncome1CBGURepository(SfeduMsSqlContext context)
        {
            _context = context;
        }

        public IQueryable<AcademyIncome1CBGU> GetAcademyIncome1CBGUs()
        {
            return _context.AcademyIncome1CBGUs;
        }

        public IQueryable<AcademyIncome1CBGU> GetAcademyIncome1CBGUs(string AcademyСategory)
        {
            return _context.AcademyIncome1CBGUs.Where(w => w.AcademyСategory == AcademyСategory);
        }

        public AcademyIncome1CBGU GetAcademyIncome1CBGU(int id)
        {
            return _context.AcademyIncome1CBGUs.FirstOrDefault(a => a.ID == id);
        }

        //public Task<AcademyIncome1CBGU> GetAcademyIncome1CBGUDataLoader(int id, [DataLoader]AcademyIncome1CBGUDataLoader academyIncome1CBGUDataLoader)
        //{   
        //    return academyIncome1CBGUDataLoader.;
        //}

        public async Task<IReadOnlyDictionary<int, AcademyIncome1CBGU>> GetAcademyIncome1CBGUsAsync(
              IReadOnlyCollection<int> academyIncome1CBGUIds,
              CancellationToken cancellationToken)
        {
            List<AcademyIncome1CBGU> posts = await _context.AcademyIncome1CBGUs.Where(c => academyIncome1CBGUIds.Contains(c.ID)).ToListAsync();
            return posts.ToDictionary(t => t.ID);
        }

    }
}
