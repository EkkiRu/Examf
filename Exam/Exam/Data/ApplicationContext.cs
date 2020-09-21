using Exam.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Application
{
    public class ApplicationContext:DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Town> Towns { get; set; }
        
        public ApplicationContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database =Exam; Trusted_Connection = True;");
        }
    }
}
