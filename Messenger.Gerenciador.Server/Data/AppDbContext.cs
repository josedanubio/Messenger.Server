using Microsoft.EntityFrameworkCore;
using Messenger.Gerenciador.Server.Models;

namespace Messenger.Gerenciador.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
