using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace CodeFirst.Models
{   
    public partial class CompanyEntities : DbContext
    {
        public CompanyEntities() : base("dbconn")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<CompanyEntities, CodeFirst.Migrations.Configuration>());
        }
    
    
        //public virtual DbSet<tblcity> tblcities { get; set; }
        public virtual DbSet<tblemployee> tblemployees { get; set; }
        //public virtual DbSet<tblstate> tblstates { get; set; }
    }
}
