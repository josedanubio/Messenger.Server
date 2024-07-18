using Microsoft.EntityFrameworkCore;
using Messenger.Gerenciador.Server.Models;

namespace Messenger.Gerenciador.Server.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Usuarios { get; set; }
        public DbSet<UsuarioStatus> UsuarioStatus { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Status)
                .WithMany()
                .HasForeignKey(u => u.Status_Id)
                .IsRequired();
        }
    }
}
