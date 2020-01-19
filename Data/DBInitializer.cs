using HackDavis2020.Data;
using HackDavis2020.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace HackDavis2020.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SiteContext context)
        {
            context.Database.EnsureCreated();

            // BLUEPRINTS
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


            //LANGUAGES
            if (context.Languages.Any())
            {
                return;   // DB has been seeded
            }

            var languages = new Language[]
            {
                new Language{ ID = 0, Lang = "C"},
                new Language{ ID = 1, Lang ="C++"},
                new Language{ ID = 2, Lang ="Java"},
                new Language{ ID = 3, Lang = "Python"},
                new Language{ ID = 4, Lang ="Javascript"},
                new Language{ ID = 5, Lang ="HTML"},
                new Language{ ID = 6, Lang = "CSS"},
                new Language{ ID = 7, Lang ="C#"},
                new Language{ ID = 8, Lang ="Prolog"},
                new Language{ ID = 9, Lang = "Go"},
                new Language{ ID = 10, Lang ="React.js"},
                new Language{ ID = 11, Lang ="Node.js"},

            };
            foreach (Language lang in languages)
            {
                context.Languages.Add(lang);
            }
            context.SaveChanges();




            //USERS
            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                new User {
                    UserID = 0,
                    Username = "raza",
                    BluePrintIDs = 1

                },
                new User {
                    UserID = 1,
                    Username = "eric",
                    BluePrintIDs = 2

                },
                new User {
                    UserID = 2,
                    Username = "kyle",
                    BluePrintIDs = 3

                },
                new User {
                    UserID = 3,
                    Username = "nikita",
                    BluePrintIDs = 4

                }
            };
            
            foreach (User s in users)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();
        
        }
    }
}