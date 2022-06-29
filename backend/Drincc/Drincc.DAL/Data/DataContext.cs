using Drincc.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Drincc.DAL.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Tea> Teas => Set<Tea>();
    }
}
