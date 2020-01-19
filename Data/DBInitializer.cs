using HackDavis2020.Data;
using HackDavis2020.Models;
using System;
using System.Linq;
using Newtonsoft.Json;
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
                new BluePrint{
                    ID=1,
                    OwnerID = 2,
                    Name="Hack Davis 2020",
                    Languages = "Java",
                    Github = "github.com/fakeurl",
                    Discord= "discord.gg/fakeurl",
                    Progress = 50,
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam accumsan, felis nec ornare lacinia, sapien sem volutpat nisi, nec scelerisque nibh risus eu nisi. Ut ac consequat felis. Morbi consectetur mauris at nibh iaculis faucibus. Etiam tincidunt nibh sit amet metus convallis, at molestie dui bibendum. Aliquam massa libero, lacinia sit amet odio id, pharetra suscipit lorem. In in tincidunt mi, at cursus enim. Integer accumsan tellus leo, ut elementum erat viverra fringilla."
                },
                new BluePrint{ID=2,
                    OwnerID = 2,
                    Name="Startup Idea",
                    Languages = "C",
                    Github = "github.com/fakeurl",
                    Discord= "discord.gg/fakeurl",
                    Progress = 20,
                    Description="Nam porttitor aliquam augue. Aenean nunc urna, condimentum et risus sit amet, scelerisque egestas lorem. Morbi sed laoreet purus. Proin at dui a leo molestie tempus in a ligula. Duis tincidunt aliquam orci, non pellentesque lorem feugiat ut. Donec mollis imperdiet neque, ac elementum urna ultrices nec. Sed neque erat, pretium a nunc in, auctor ultrices felis. Proin et nisl tempor elit convallis iaculis."
                },
                new BluePrint{ID=3,
                    OwnerID = 1,
                    Name="Machine Learning BlockChain",
                    Languages = "HTML",
                    Github = "github.com/fakeurl",
                    Discord= "discord.gg/fakeurl",
                    Progress = 10,
                    Description="Donec luctus gravida nibh rutrum vehicula. Donec egestas ut turpis sit amet tempor. Phasellus id urna eros. Pellentesque viverra libero at turpis rhoncus maximus. Proin lobortis, orci ut dapibus porttitor, ante elit imperdiet nulla, vel mattis ex libero at metus. Integer in pulvinar nulla, nec sagittis ex. Maecenas cursus enim justo, a sagittis ex semper sit amet."
                },
                new BluePrint{ID=4,
                    OwnerID = 3,
                    Name="AI Generated Cloud",
                    Languages = "Python",
                    Github = "github.com/fakeurl",
                    Discord= "discord.gg/fakeurl",
                    Progress = 0,
                    Description="Aliquam at commodo augue. Pellentesque imperdiet tempor lectus non vulputate. Sed quis molestie turpis, eget egestas leo. Proin tincidunt velit ipsum, id placerat lacus blandit nec. Vivamus ut enim quis nisl feugiat bibendum. Quisque in condimentum nisi, quis blandit libero. Proin interdum sit amet ligula sed ultrices."
                },
                new BluePrint{
                    ID=5,
                    OwnerID = 2,
                    Name="AI Search Engine",
                    Languages = "Java",
                    Github = "github.com/fakeurl",
                    Discord= "discord.gg/fakeurl",
                    Progress = 70,
                    Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam accumsan, felis nec ornare lacinia, sapien sem volutpat nisi, nec scelerisque nibh risus eu nisi. Ut ac consequat felis. Morbi consectetur mauris at nibh iaculis faucibus. Etiam tincidunt nibh sit amet metus convallis, at molestie dui bibendum. Aliquam massa libero, lacinia sit amet odio id, pharetra suscipit lorem. In in tincidunt mi, at cursus enim. Integer accumsan tellus leo, ut elementum erat viverra fringilla."
                },
                new BluePrint{ID=6,
                    OwnerID = 2,
                    Name="Data Mining Blockchain",
                    Languages = "C",
                    Github = "github.com/fakeurl",
                    Discord= "discord.gg/fakeurl",
                    Progress = 10,
                    Description="Nam porttitor aliquam augue. Aenean nunc urna, condimentum et risus sit amet, scelerisque egestas lorem. Morbi sed laoreet purus. Proin at dui a leo molestie tempus in a ligula. Duis tincidunt aliquam orci, non pellentesque lorem feugiat ut. Donec mollis imperdiet neque, ac elementum urna ultrices nec. Sed neque erat, pretium a nunc in, auctor ultrices felis. Proin et nisl tempor elit convallis iaculis."
                },
                new BluePrint{ID=7,
                    OwnerID = 1,
                    Name="Voice Recognition AI",
                    Languages = "HTML",
                    Github = "github.com/fakeurl",
                    Discord= "discord.gg/fakeurl",
                    Progress = 30,
                    Description="Donec luctus gravida nibh rutrum vehicula. Donec egestas ut turpis sit amet tempor. Phasellus id urna eros. Pellentesque viverra libero at turpis rhoncus maximus. Proin lobortis, orci ut dapibus porttitor, ante elit imperdiet nulla, vel mattis ex libero at metus. Integer in pulvinar nulla, nec sagittis ex. Maecenas cursus enim justo, a sagittis ex semper sit amet."
                },
                new BluePrint{ID=8,
                    OwnerID = 3,
                    Name="Preserving Net Neutrality",
                    Languages = "Python",
                    Github = "github.com/fakeurl",
                    Discord= "discord.gg/fakeurl",
                    Progress = 40,
                    Description="Aliquam at commodo augue. Pellentesque imperdiet tempor lectus non vulputate. Sed quis molestie turpis, eget egestas leo. Proin tincidunt velit ipsum, id placerat lacus blandit nec. Vivamus ut enim quis nisl feugiat bibendum. Quisque in condimentum nisi, quis blandit libero. Proin interdum sit amet ligula sed ultrices."
                },

            };
            foreach (BluePrint s in blueprints)
            {
                context.BluePrints.Add(s);
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
                    UserID = 1,
                    Username = "raza",
                    BluePrintIDs = 1,
                    Languages = JsonConvert.SerializeObject(
                        new Language[]
                        {
                            new Language{ ID = 0, Lang = "C"},
                            new Language{ ID = 1, Lang ="C++"},
                            new Language{ ID = 2, Lang ="Java"},

                        }
                    )

                },
                new User {
                    UserID = 2,
                    Username = "eric",
                    BluePrintIDs = 2,
                    Languages = JsonConvert.SerializeObject(
                        new Language[]
                        {
                            new Language{ ID = 3, Lang = "Python"},
                            new Language{ ID = 4, Lang ="Javascript"},
                            new Language{ ID = 5, Lang ="HTML"},

                        }
                    )

                },
                new User {
                    UserID = 3,
                    Username = "kyle",
                    BluePrintIDs = 3,
                    Languages = JsonConvert.SerializeObject(
                        new Language[]
                        {
                            new Language{ ID = 8, Lang ="Prolog"},
                            new Language{ ID = 9, Lang = "Go"},
                            new Language{ ID = 10, Lang ="React.js"},
                            new Language{ ID = 11, Lang ="Node.js"},

                        }
                    )

                },
                new User {
                    UserID = 4,
                    Username = "nikita",
                    BluePrintIDs = 4,
                    Languages = JsonConvert.SerializeObject(
                        new Language[]
                        {
                            new Language{ ID = 3, Lang = "Python"},
                            new Language{ ID = 4, Lang ="Javascript"},
                            new Language{ ID = 5, Lang ="HTML"},
                            new Language{ ID = 6, Lang = "CSS"},
                            new Language{ ID = 7, Lang ="C#"},
                            new Language{ ID = 8, Lang ="Prolog"},
                            new Language{ ID = 9, Lang = "Go"},
                            new Language{ ID = 10, Lang ="React.js"},
                            new Language{ ID = 11, Lang ="Node.js"},
                        }
                    )

                }
            };
            
            foreach (User s in users)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();



            //LANGUAGES
            if (context.Languages.Any())
            {
                return;   // DB has been seeded
            }

            var languages = new Language[]
            {
                
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
                new Language{ ID = 12, Lang = "C"},

            };
            foreach (Language lang in languages)
            {
                context.Languages.Add(lang);
            }
            context.SaveChanges();


        
        }
    }
}