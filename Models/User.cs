using System;
using System.Collections.Generic;
namespace HackDavis2020.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        //public Builder Builder { get; set; }
        //public Supporter Supporter { get; set; }
        
        public int BluePrintIDs { get; set; }
    }





    public class Builder
    {
        public BuilderSettings Settings { get; set; }
        public ICollection<BluePrint> BluePrints { get; set; }
    }

    public class Supporter
    {
        public SupportorSettings Settings { get; set; }

    }


    public class BuilderSettings {
        public string PrefferedLangs { get; set; }
        public int FreeHours { get; set; }
        public string Email { get; set; }
        public string DiscordTag { get; set; }
    }

    public class SupportorSettings {
        public bool GetEmailUpdates { get; set; }

    }




    //Static class of our permanent user
    public static class LoggedInUser {

        public static BuilderSettings BuilderSettings { get; } = new BuilderSettings { PrefferedLangs = "C, Javascript, HTML", FreeHours = 5 };
        public static SupportorSettings SupportorSettings { get; } = new SupportorSettings { GetEmailUpdates = true };

        //public static Builder Builder { get; set; } = new Builder { Settings = BuilderSettings };
        //public static Supporter Supporter { get; set; } = new Supporter { Settings = SupportorSettings };

        public static User User { get; set; } = new User
        {
            UserID = 4,
            Username = "nikita",
            BluePrintIDs = 1
        };

    }

}
