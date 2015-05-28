
namespace Supervisor.Context
{
    using Supervisor.Models;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class Contexts : DbContext
    {
        public Contexts(string ConnectionStr)
            :base("Contexts")
        { }

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