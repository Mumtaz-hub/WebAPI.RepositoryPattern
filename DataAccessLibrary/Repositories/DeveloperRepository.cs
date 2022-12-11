using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore.Repositories
{
    public class DeveloperRepository : GenericRepository<Developer>, IDeveloperRepository
    {
        public DeveloperRepository(ApplicationContext context) : base(context)
        {
        }

        public IEnumerable<Developer> GetTopDevelopers(int count)
        {
            return _context.Developers.OrderByDescending(x => x.Followers).Take(count).ToList();
        }
    }
    
}
