using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ArtCommissionApp
{
    class ArtPackageContext : DbContext
    {
        public DbSet<Package> packageList { get; set; }
        public DbSet<PackageInfo> Package { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=ArtCommissionApp;Trusted_Connection=True;MultipleActiveResultSets=true");

        }
    }
}
