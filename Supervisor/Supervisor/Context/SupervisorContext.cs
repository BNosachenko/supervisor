
namespace Supervisor.Context
{
    using Supervisor.Models;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class SupervisorContext : DbContext
    {
        public SupervisorContext()
            : base("SupervisorContext")
        {
#if DEBUG
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
#endif
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.UseDatabaseNullSemantics = true;
        }

        public DbSet<AgentModel> Agents { get; set; }

        public DbSet<ContractModel> Contracts { get; set; }

        public DbSet<ProvidedGoodsModel> ProvidedGoods { get; set; }

        public DbSet<ProviderModel> Providers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}