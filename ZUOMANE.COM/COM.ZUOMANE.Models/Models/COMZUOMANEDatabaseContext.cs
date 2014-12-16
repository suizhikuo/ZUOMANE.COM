using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using COM.ZUOMANE.Models.Mapping;

namespace COM.ZUOMANE.Models
{
    public partial class COMZUOMANEDatabaseContext : DbContext
    {
        static COMZUOMANEDatabaseContext()
        {
            Database.SetInitializer<COMZUOMANEDatabaseContext>(null);
        }

        public COMZUOMANEDatabaseContext()
            : base("Name=COMZUOMANEDatabaseContext")
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArticleMap());
            modelBuilder.Configurations.Add(new ArticleCategoryMap());
            modelBuilder.Configurations.Add(new ErrorLogMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TestMap());
        }
    }
}
