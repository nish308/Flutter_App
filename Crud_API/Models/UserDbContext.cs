using Microsoft.EntityFrameworkCore;

namespace Crud_API.Models
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Users> users { get; set; }
    }
}
