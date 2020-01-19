using System;
namespace HackDavis2020.Models
{
    public class User
    {
        public int UserID { get; set; }
        public int ProjectID { get; set; }
        public string Username { get; set; }
        public Builder Builder { get; set; }
        public Supporter Supporter { get; set; }
        

    }

    public class Builder
    {
        public BluePrint[] BluePrints {get; set;}
        public BuilderSettings Settings { get; set; }

        /*
        public BluePrint[] GetBluePrints() {


        }*/
    }

    public class Supporter
    {
        public SupportorSettings Settings { get; set; }

    }


    public class BuilderSettings {
        public string[] PrefferedLangs { get; set; }
        public int FreeHours { get; set; }
        public string Email { get; set; }
        public string DiscordTag { get; set; }
    }

    public class SupportorSettings {
        public bool GetEmailUpdates { get; set; }

    }




    //Static class of our permanent user
    public static class LoggedInUser {

        public static BuilderSettings BuilderSettings { get; } = new BuilderSettings { PrefferedLangs = new String[] { "C", "Javascript", "HTML" }, FreeHours = 5 };
        public static SupportorSettings SupportorSettings { get; } = new SupportorSettings { GetEmailUpdates = true };

        public static Builder Builder { get; set; } = new Builder { Settings = BuilderSettings };
        public static Supporter Supporter { get; set; } = new Supporter { Settings = SupportorSettings };

        public static User LoggedInUsr { get; set; } = new User { UserID = 69, Username= "Roy", ProjectID = 1, Builder = Builder, Supporter = Supporter }; 

    }

}
