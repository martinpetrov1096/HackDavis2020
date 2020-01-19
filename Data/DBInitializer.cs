using HackDavis2020.Data;
using HackDavis2020.Models;
using System;
using System.Linq;

namespace HackDavis2020.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SiteContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.BluePrints.Any())
            {
                return;   // DB has been seeded
            }

            var blueprints = new BluePrint[]
            {
            new BluePrint{ID=1, Name="Project 1", Description="Will this fucking work 1"},
            new BluePrint{ID=2, Name="Project 2", Description="Will this fucking work 2"},
            new BluePrint{ID=3, Name="Project 3", Description="Will this fucking work 3"},
            new BluePrint{ID=4, Name="Project 4", Description="Will this fucking work 4"},

            };
            foreach (BluePrint s in blueprints)
            {
                context.BluePrints.Add(s);
            }
            context.SaveChanges();

            
        }
    }
}