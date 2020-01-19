using System;
namespace HackDavis2020.Models
{
    public class BluePrint
    {
        public int ID { get; set; }
        public int OwnerID { get; set; }    //User ID of the owner of the blueprint
        public int Progress { get; set; }

        public string Name { get; set; }
        public string Github { get; set; }
        public string Discord { get; set; }

        public string Description { get; set; }
        public string Languages { get; set; }
    }
}
