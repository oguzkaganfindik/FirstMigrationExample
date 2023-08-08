using Microsoft.EntityFrameworkCore;
using MigrationOrnegi.Models;

namespace MigrationOrnegi.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Urun> Urun { get; set; }
    }
}
