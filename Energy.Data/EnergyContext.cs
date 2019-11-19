using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Energy.Domain;

namespace Energy.Data
{
    public class EnergyContext:DbContext
    {
        public DbSet<Material> Materials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server = (localdb)\\mssqllocaldb; Database = EnergyDB; Trusted_Connection = True; ");
        }
    }
}
