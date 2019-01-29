using Microsoft.EntityFrameworkCore;
using System;
using test11.Models;

namespace Sqlite
{


    public class DataBaseContext : DbContext
    {
        public DbSet<Product> products { get; set; }
        private readonly string _databasePath;

        public DataBaseContext(string databasPath)
        {
            _databasePath = databasPath;
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");

        }


    }
}
