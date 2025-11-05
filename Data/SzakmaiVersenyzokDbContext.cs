using Microsoft.EntityFrameworkCore;
using Euriskills.Models;

namespace Euriskills.Data
{
    public class SzakmaiVersenyzokDbContext : DbContext
    {
        public SzakmaiVersenyzokDbContext(DbContextOptions<SzakmaiVersenyzokDbContext> options) :base(options)
        {
            
        }

        public DbSet<Versenyzo> Versenyzok {  get; set; }
        public DbSet<Szakma> Szakmak {  get; set; }
        public DbSet<Orszag> Orszagok {  get; set; }
    }
}
