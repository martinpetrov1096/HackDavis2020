using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HackDavis2020.Models
{
    public class UserBluePrints
    {
            public IQueryable<BluePrint> BluePrints { get; set; }
            public User User { get; set; }

        
    }
}
