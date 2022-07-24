using LoLChampionsReview.Entities;
using Microsoft.EntityFrameworkCore;

namespace LoLChampionsReview.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Champion> Champions { get; set; }
        public DbSet<Region> Regions { get; set; }
    }
}
