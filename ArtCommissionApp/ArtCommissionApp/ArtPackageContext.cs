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
        public DbSet<Package> Package { get; set; }
        public DbSet<PackageInfo> PackageInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=ArtCommissionApp;Trusted_Connection=True;MultipleActiveResultSets=true");
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Package>(b =>
            {
                b.HasKey(p => p.PackId);
                b.ToTable("Package");
            });

            builder.Entity<PackageInfo>(b =>
            {
                b.HasKey(c => c.InfoId);
                b.Property(c => c.PackId).IsRequired();
                b.HasOne<Package>()
                    .WithMany()
                    .HasForeignKey(c => c.PackId);
                b.ToTable("PackageInfo");
            });

        }

        


    }
}
