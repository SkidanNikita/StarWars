using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars
{
    public class Context : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public Context()
        {
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StarWarsDb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Person>().HasOne(p => p.IsPerson);
            builder.Entity<Person>().ToTable("Persons");
        }
    }
}
