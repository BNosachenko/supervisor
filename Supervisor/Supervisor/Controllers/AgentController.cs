
namespace Supervisor.Controllers
{
    using Supervisor.Context;
    using Supervisor.Models;
    using System;
    using System.Collections.Generic;
    using System.Web.Http;

    public class AgentController : BaseModelController<AgentModel>
    {
        public AgentController(SupervisorContext ctx)
            :base(ctx)
        {

        }
    }
}