using Microsoft.EntityFrameworkCore;
using Portfolio.Standard.Entities;
using System.Reflection;

namespace Portfolio.Standard.DAL
{
    public class PortfolioContext : DbContext
    {
        public PortfolioContext() 
        {
            this.Database.EnsureCreated();
        }
        public DbSet<StockEntity> stocks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=PortfolioDatabase.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map table names
            modelBuilder.Entity<StockEntity>().ToTable("Stocks", "portfolio");
            modelBuilder.Entity<StockEntity>(entity =>
            {
                entity.HasKey(e => e.StockId);
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
