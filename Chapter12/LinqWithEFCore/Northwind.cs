using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace MyLibrary.Shared
{
    public class Northwind : DbContext
    {
        public DbSet<Category> Categories {get; set;}

        public DbSet<Product> Products {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");

            optionsBuilder.UseSqlite($"Filename={path}");
        }
    }
}