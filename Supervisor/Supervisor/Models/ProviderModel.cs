
using System.Collections.Generic;
namespace Supervisor.Models
{
    public class ProviderModel : BaseModel
    {
        public string Address { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<AgentModel> Agents { get; set; }
    }
}