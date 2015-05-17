
namespace Supervisor.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class AgentModel : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        [ForeignKey("Providers")]
        public IList<ProviderModel> Providers { get; set; }

    }
}