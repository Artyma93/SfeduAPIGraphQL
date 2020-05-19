using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistance.Repositories.Interfaces
{
    public interface IAcademyIncome1CBGUDataLoaderRepository
    {
        IReadOnlyList<AcademyIncome1CBGU> GetAcademyIncome1CBGUsDataLoader(IReadOnlyList<string> keys);
    }
}
