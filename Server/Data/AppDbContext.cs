using Microsoft.EntityFrameworkCore;
using Server.Entities;

namespace Server.Data
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<AppUser> Users { get; set; }
    }
}
