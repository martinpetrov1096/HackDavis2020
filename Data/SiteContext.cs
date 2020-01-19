
using HackDavis2020.Models;
using Microsoft.EntityFrameworkCore;

namespace HackDavis2020.Data
{
    public class SiteContext : DbContext
    {
        public SiteContext(DbContextOptions<SiteContext> options) : base(options)
        {
        }

        public DbSet<BluePrint> BluePrints { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BluePrint>().ToTable("BluePrint");

        }
    }
}
