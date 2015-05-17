
namespace Supervisor.Context
{
    using Supervisor.Models;
    using System.Data.Entity;

    public class Contexts : DbContext
    {
        public Contexts(string ConnectionStr)
            :base("DbConnection")
        { }

        public System.Data.Entity.DbSet<AgentModel> Agents { get; set; }

        public System.Data.Entity.DbSet<ContractModel> Contracts { get; set; }

        public System.Data.Entity.DbSet<ProvidedGoodsModel> ProvidedGoods { get; set; }

        public System.Data.Entity.DbSet<ProviderModel> Providers { get; set; }

    }
}