using Microsoft.EntityFrameworkCore;

namespace Server.Models
{
    public class AirlineContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }

    }
}
