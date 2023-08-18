using Friends.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Friends.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Friend> Friends { get; set; } 
    }
}
