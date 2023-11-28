using CA_Entity.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Entity
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
            //ConnectionStringSettings settings =
            //        ConfigurationManager.ConnectionStrings["aulaentity"];

            ////string retorno = "";
            //string retorno = ConfigurationManager.ConnectionStrings["aulaentity"].ConnectionString; ;

            //if (settings != null)
            //    retorno = settings.ConnectionString;


            optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=aulaentity; User ID=aulaentity; password=senha_1234;language=Portuguese");
            //optionsBuilder.UseSqlServer(retorno);

            //optionsBuilder.UseLazyLoadingProxies();
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
