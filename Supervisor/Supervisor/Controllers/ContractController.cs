
namespace Supervisor.Controllers
{
    using Supervisor.Context;
    using Supervisor.Models;
    using System.Web.Http;

    public class ContractController : BaseModelController<ContractModel>
    {
        public ContractController(SupervisorContext ctx)
            :base(ctx)
        {

        }
    }
}
