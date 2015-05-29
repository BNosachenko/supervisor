
namespace Supervisor.Controllers
{
    using Supervisor.Context;
    using Supervisor.Models;
    using System;
    //using System.Web.Http;
    using System.Web.Mvc;

    public class ProviderController : BaseModelController<ProviderModel>
    {
        public ProviderController(SupervisorContext ctx)
            :base(ctx)
        {

        }
    }
}
