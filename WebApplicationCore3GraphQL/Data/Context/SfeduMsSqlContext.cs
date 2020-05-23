using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Data.Context.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore3GraphQL.Infra.Data.Models;

namespace Data.Context
{

    class SfeduMsSqlContextFactory : IDesignTimeDbContextFactory<SfeduMsSqlContext>
    {
        string connectHome = @"Server=(localdb)\mssqllocaldb;AttachDbFileName=C:\SQL\BD\Sfedu\SFEDU.mdf;Database=SFEDU;Trusted_Connection=True";
        string connectWork = @"Server=(localdb)\mssqllocaldb;AttachDbFileName=D:\Disk_E\1 DB\1 MS SQL\SFEDU\TestDB1.mdf;Database=TestDB1;Trusted_Connection=True";

        public SfeduMsSqlContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SfeduMsSqlContext>();
            optionsBuilder.UseSqlServer(connectHome, opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds));

            return new SfeduMsSqlContext(optionsBuilder.Options);
        }
    }
    public class SfeduMsSqlContext : DbContext
    {
        string conectHome = @"Server=(localdb)\mssqllocaldb;AttachDbFileName=D:\SQL\sfedu\SFEDU.mdf;Database=SFEDU;Trusted_Connection=True";
        string conectWork = @"Server=(localdb)\mssqllocaldb;AttachDbFileName=D:\Disk_E\1 DB\1 MS SQL\SFEDU\TestDB1.mdf;Database=TestDB1;Trusted_Connection=True";

        public SfeduMsSqlContext() { }
        public SfeduMsSqlContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Academy1CBGU> Academy1CBGUs { get; set; }
        public virtual DbSet<AcademyIncome1CBGU> AcademyIncome1CBGUs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(conectHome);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Academy1CBGUConfiguration());
            modelBuilder.ApplyConfiguration(new AcademyIncome1CBGUConfiguration());

        }
    }
}
