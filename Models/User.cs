using System;
namespace HackDavis2020.Models
{
    public class User
    {
        public int UserID { get; set; }
        public int ProjectID { get; set; }
        public string Username { get; set; }
        public BuilderSettings BuilderSettings {get; set;}
        public SupportorSettings SupportorSettings { get; set; }

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
        public static SupportorSettings SupportorSettings { get; } = new SupportorSettings {GetEmailUpdates = true};
        public static User LoggedInUsr { get; set; } = new User { UserID = 69, Username= "Roy", ProjectID = 1, BuilderSettings = BuilderSettings }; 

    }

}