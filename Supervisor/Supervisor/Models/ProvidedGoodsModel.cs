
namespace Supervisor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ProvidedGoodsModel : BaseModel
    {
        public Guid AgentId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual AgentModel Agent { get; set; }
        public virtual ICollection<ContractModel> Contracts { get; set; }
    }
}