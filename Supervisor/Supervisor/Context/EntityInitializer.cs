
namespace Supervisor.Context
{
    using Supervisor.Models;
    using System.Collections.Generic;
    using System.Data.Entity;

    public class EntityInitializer : DropCreateDatabaseIfModelChanges<Contexts>
    {
        protected override void Seed(Contexts context)
        {
            var agents = new List<AgentModel>
            {
                new AgentModel{FirstName="Bogdan", LastName="Nosachenko", Phone="911",  }
            };
            agents.ForEach(s => context.Agents.Add(s));
            context.SaveChanges();

            var providers = new List<ProviderModel>
            {
                new ProviderModel{Address="Kharkiv", Name="Comfy", Phone="111111"  }
            };
            providers.ForEach(s => context.Providers.Add(s));
            context.SaveChanges();
        }
    }
}