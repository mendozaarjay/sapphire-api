using Microsoft.EntityFrameworkCore;
using SapphireAPI.Models;

namespace SapphireAPI.Persistence
{
    public class SapphireDbContext : DbContext
    {
        public SapphireDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<SapphireAPI.Models.Company> Company { get; set; }
    }
}
