using AulaAPI.DataModels;
using Microsoft.EntityFrameworkCore;

namespace AulaAPI
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Email> Emails { get; set; }

        public Contexto()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=API_Aula; User ID=usuario; password=senha;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>()
                .HasOne(e => e.pessoa)
                .WithMany(p => p.Emails)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
