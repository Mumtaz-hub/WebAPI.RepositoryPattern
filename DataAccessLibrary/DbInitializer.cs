using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationContext context)
        {
            context.Database.EnsureCreated();

            if (context.Developers.Any())
            {
                return;
            }

            var developers = new Developer[]
            {
                new Developer{Name="Developer1", Followers=100},
                new Developer{Name="Developer2", Followers=200},
                new Developer{Name="Developer3", Followers=300},
                new Developer{Name="Developer4", Followers=400},
                new Developer{Name="Developer5", Followers=500},
                new Developer{Name="Developer6", Followers=600},
                new Developer{Name="Developer7", Followers=700},
                new Developer{Name="Developer8", Followers=800},
                new Developer{Name="Developer9", Followers=900},
                new Developer{Name="Developer10", Followers=1000},
            };

            foreach (Developer d in developers)
            {
                context.Developers.Add(d);
            }

            context.SaveChanges();

            var projects = new Project[]
            {
                new Project{Name="Project1", DeveloperId = 1},
                new Project{Name="Project2", DeveloperId = 2},
                new Project{Name="Project3", DeveloperId = 3},
                new Project{Name="Project4", DeveloperId = 4},
                new Project{Name="Project5", DeveloperId = 5},
                new Project{Name="Project6", DeveloperId = 6},
                new Project{Name="Project7", DeveloperId = 7},
                new Project{Name="Project8", DeveloperId = 8},
                new Project{Name="Project9", DeveloperId = 9},
                new Project{Name="Project10", DeveloperId = 10},
            };

            foreach (Project p in projects)
            {
                context.Projects.Add(p);
            }

            context.SaveChanges();
        }
    }
}
