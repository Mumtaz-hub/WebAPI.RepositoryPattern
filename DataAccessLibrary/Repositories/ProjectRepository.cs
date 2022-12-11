using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(ApplicationContext context) : base(context)
        {
        }

        public IEnumerable<Project> GetTopProjects(int count)
        {
            return _context.Projects.OrderByDescending(x => x.Name).Take(count).ToList();
        }
    }
    }
