using API_Countries.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Countries.Database
{
    public class CountryDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=db_countries;Trusted_Connection=True;");
        }
    }
}
