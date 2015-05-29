
namespace Supervisor.Controllers
{
    using Supervisor.Context;
    using Supervisor.Models;
    using System.Web.Http;

    public class ProvidedGoodsController : BaseModelController<ProvidedGoodsModel>
    {
        public ProvidedGoodsController(SupervisorContext ctx)
            :base(ctx)
        {

        }
    }
}
