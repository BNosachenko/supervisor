
namespace Supervisor.Context
{
    using Supervisor.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class EntityInitializer : DropCreateDatabaseIfModelChanges<SupervisorContext>
    {
        protected override void Seed(SupervisorContext context)
        {
            var providers = new List<ProviderModel>
            {
                new ProviderModel { Id = Guid.NewGuid(), Address="Kharkiv", Name="Comfy", Phone="111111"  }
            };
            providers.ForEach(s => context.Providers.Add(s));

            var agents = new List<AgentModel>
            {
                new AgentModel { Id = Guid.NewGuid(), FirstName="Bogdan", LastName="Nosachenko", Phone="911", Provider = providers.First() }
            };

            agents.ForEach(s => context.Agents.Add(s));

            var providedGoods = new List<ProvidedGoodsModel>
            {
                new ProvidedGoodsModel { Id = Guid.NewGuid(), Name="Milk", Price=78787, Agent = agents.First() }
            };

            providedGoods.ForEach(s => context.ProvidedGoods.Add(s));

            var contract = new List<ContractModel>
            {
                new ContractModel { Id = Guid.NewGuid(), Number=15, ContractDate=DateTime.Now, ProductCount=15, ProvidedGood = providedGoods.First() }
            };

            contract.ForEach(s => context.Contracts.Add(s));
            context.SaveChanges();
        }
    }
}