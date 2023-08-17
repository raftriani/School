using Microsoft.EntityFrameworkCore;
using School.Domain.Entities;

namespace School.Infra.Data
{
    public class SchoolContext : DbContext
    {
        //public SchoolContext() { }  

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Schooling>().HasData(
                new Schooling()
                {
                    Id = 1,
                    Description = "Infantil"
                });

            modelBuilder.Entity<Schooling>().HasData(
               new Schooling()
               {
                   Id = 2,
                   Description = "Fundamental"
               });

            modelBuilder.Entity<Schooling>().HasData(
               new Schooling()
               {
                   Id = 3,
                   Description = "Médio"
               });

            modelBuilder.Entity<Schooling>().HasData(
               new Schooling()
               {
                   Id = 4,
                   Description = "Superior"
               });
        }

        public DbSet<User> User { get; set; }
        public DbSet<Schooling> Schooling { get; set; }
        public DbSet<SchoolRecords> SchoolRecords { get; set; }
    }
}
