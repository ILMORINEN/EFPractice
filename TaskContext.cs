using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Configuration;

namespace EFPractice
{
    public class TaskContext : DbContext
    {

        public DbSet<Human>? Humans { get; set; }
        
        public TaskContext() : base(ConfigurationManager.ConnectionStrings["SQLExpress"].ConnectionString) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
