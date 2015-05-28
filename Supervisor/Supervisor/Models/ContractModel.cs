
namespace Supervisor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ContractModel : BaseModel
    {
        public Guid ProvidedGoodId { get; set; }
        public int Number { get; set; }
        public DateTime ContractDate { get; set; }
        public int ProductCount { get; set; }

        public virtual ProvidedGoodsModel Providers { get; set; }
    }
}