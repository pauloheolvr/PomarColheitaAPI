using Microsoft.EntityFrameworkCore;
using PomarFrutasAPI.Models;

namespace Backoffice.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<Species> Species { get; set; }
        public DbSet<Trees> Trees { get; set; }
        public DbSet<Harvest> Harvest { get; set; }
        public DbSet<GroupTrees> GroupTrees { get; set; }
    }
}