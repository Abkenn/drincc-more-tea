using Drincc.DAL.Data.EntityConfigurations;
using Drincc.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Drincc.DAL.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Tea> Teas => Set<Tea>();

        public DbSet<SessionNote> SessionNotes => Set<SessionNote>();

        public DbSet<PriceDetails> PriceDetails => Set<PriceDetails>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TeaEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SessionNoteTypeConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
