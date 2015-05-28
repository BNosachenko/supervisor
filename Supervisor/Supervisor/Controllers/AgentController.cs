
namespace Supervisor.Controllers
{
    using Supervisor.Context;
    using Supervisor.Models;
    using System;
    using System.Collections.Generic;
    using System.Web.Http;


    public class AgentController : BaseModelController<AgentModel>
    {
        private Contexts db = new Contexts("Contexts");
        // GET: Agent
        public string GetAgent()
        {
            String agents = db.Agents.ToString();
            return agents;
        }
    }
}