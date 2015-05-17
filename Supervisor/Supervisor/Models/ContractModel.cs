
namespace Supervisor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ContractModel : BaseModel
    {
        public int Number { get; set; }
        public DateTime ContractDate { get; set; }
        public int ProductCount { get; set; }
        [ForeignKey("ProvidedGoods")]
        public IList<ProvidedGoodsModel> ProvidedGoods { get; set; }
    }
}