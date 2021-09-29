using Microsoft.EntityFrameworkCore;

namespace Datafication.Repositories.Contexts
{
    public class IceCreamDbContext : DbContext
    {
        public IceCreamDbContext(DbContextOptions<IceCreamDbContext> options) 
        : base(options) 
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IceCream>()
                .HasOne(m => m.)
        }

    }
}