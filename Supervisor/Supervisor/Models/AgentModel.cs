
namespace Supervisor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class AgentModel : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public Guid ProviderId { get; set; }

        public virtual ProviderModel Provider { get; set; }
        
    }
}