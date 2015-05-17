
namespace Supervisor.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ProvidedGoodsModel : BaseModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        [ForeignKey("Agents")]
        public IList<AgentModel> Agents { get; set; }
    }
}