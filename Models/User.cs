using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HackDavis2020.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public int BluePrintIDs { get; set; }
        public string Languages { get; set; }
    }


    //Static class of our permanent user
    public static class LoggedInUser {
        public static User User { get; set; } = new User
        {
            UserID = 2,
            Username = "martin",
            BluePrintIDs = 1,
            Languages = "C C++ Java Python Go"
                        
        };

    }

}
