using MightBlade.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MightBlade.Data
{
    public class MBContext : DbContext
    {
        public MBContext(DbContextOptions<MBContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<MapTile> MapTiles { get; set; }
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}