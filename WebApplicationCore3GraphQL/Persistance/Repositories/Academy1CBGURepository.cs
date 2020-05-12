using Data.Context;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class Academy1CBGURepository : IAcademy1CBGURepository
    {
        public SfeduMsSqlContext _context { get; }
        public Academy1CBGURepository(SfeduMsSqlContext context)
        {
            _context = context;
        }

        public IQueryable<Academy1CBGU> GetAcademy1CBGUs()
        {
            return _context.Academy1CBGUs;
        }
        //public Academy1CBGU GetAcademy1CBGU(Guid id)
        //{
        //    return _context.Academy1CBGUs.FirstOrDefault(a => a.ID == id);
        //}

        //public async Task<IReadOnlyDictionary<Guid, Academy1CBGU>> GetAcademy1CBGUsAsync(
        //      IReadOnlyCollection<Guid> userIds,
        //      CancellationToken cancellationToken)
        //{
        //    List<Academy1CBGU> posts = await _context.Academy1CBGUs.Where(c => userIds.Contains(c.ID)).ToListAsync();
        //    return posts.ToDictionary(t => t.ID);
        //}

        public Academy1CBGU GetAcademy1CBGU(int id)
        {
            return _context.Academy1CBGUs.FirstOrDefault(a => a.ID == id);
        }

        public async Task<IReadOnlyDictionary<int, Academy1CBGU>> GetAcademy1CBGUsAsync(
              IReadOnlyCollection<int> academy1CBGUIds,
              CancellationToken cancellationToken)
        {
            List<Academy1CBGU> posts = await _context.Academy1CBGUs.Where(c => academy1CBGUIds.Contains(c.ID)).ToListAsync();
            return posts.ToDictionary(t => t.ID);
        }

    }
}
