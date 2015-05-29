
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
            context.SaveChanges();
        }
    }
}