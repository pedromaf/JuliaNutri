using JuliaNutri.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace JuliaNutri.Data
{
    public class JuliaNutriDbContext : DbContext
    {
        public JuliaNutriDbContext(DbContextOptions<JuliaNutriDbContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }

        public DbSet<Subscriber> Subscribers { get; set; }
    }
}
