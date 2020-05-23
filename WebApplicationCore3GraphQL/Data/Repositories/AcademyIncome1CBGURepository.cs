using Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebApplicationCore3GraphQL.Infra.Data.Models;
using WebApplicationCore3GraphQL.Infra.Data.Repositories.Interfaces;

namespace WebApplicationCore3GraphQL.Infra.Data.Repositories
{
    public class AcademyIncome1CBGURepository : IAcademyIncome1CBGURepository
    {
        public SfeduMsSqlContext _context { get; }
        public AcademyIncome1CBGURepository(SfeduMsSqlContext context)
        {
            _context = context;
        }

        // v1
        public IQueryable<AcademyIncome1CBGU> GetAcademyIncome1CBGUs()
        {
            return _context.AcademyIncome1CBGUs;
        }

        // v2
        //public Task<AcademyIncome1CBGU> GetAcademyIncome1CBGUsDataLoader()
        //{
        //    var dataLoader = _context.GroupDataLoader<int, AcademyIncome1CBGU>();
        //    //return _context.AcademyIncome1CBGUs;
        //}



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

        //public async Task<ILookup<int, AcademyIncome1CBGU>> GetUsersByCountry(
        //    IReadOnlyList<string> countries,
        //    CancellationToken cancellationToken)
        //{
        //    IQueryable<AcademyIncome1CBGU> academyIncomeQueryable = _context.AcademyIncome1CBGUs.AsQueryable();
        //    IEnumerable<AcademyIncome1CBGU> academyIncomeEnumerable = academyIncomeQueryable.AsEnumerable();


        //    var academy = from a in academyIncomeEnumerable
        //              where a.PropertyTaxDistribution > 0
        //              orderby a.Academy
        //              group a by a.Academy into g
        //              select new ViewTax { Id = g.Key, Value = g.Sum(item => item.PropertyTaxDistribution) };


        //    //var filters = new List<AcademyIncome1CBGU>();

        //    //foreach (string country in countries)
        //    //{
        //    //    //filters.Add(Builders<AcademyIncome1CBGU>.Filter.Eq(u => u.Country, country));

        //    //    filters.Add()
        //    //}

        //    //List<AcademyIncome1CBGU> users = await _userCollection
        //    //    .Find(Builders<AcademyIncome1CBGU>.Filter.Or(filters))
        //    //    .ToListAsync(cancellationToken);

        //    //return users.ToLookup(t => t.Country);
        //}
    }
}
