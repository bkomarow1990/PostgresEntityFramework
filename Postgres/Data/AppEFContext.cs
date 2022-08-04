using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Postgres.Entities;

namespace Postgres.Data
{
    public class AppEFContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Database=ParsingDB;Port=5432;User Id=postgres;Password=11PostgresAdminPassword@#33");
            //base.OnConfiguring(optionsBuilder);
        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CompanyType> CompanyTypes { get; set; }
        public virtual DbSet<People> Peoples { get; set; }
    }
}
