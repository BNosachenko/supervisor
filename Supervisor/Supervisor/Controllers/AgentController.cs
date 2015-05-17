
namespace Supervisor.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;


    public class AgentController : ApiController
    {
        // GET: Agent
        public IEnumerable<string> GetAgent()
        {
            return new string[] {"Hello"};
        }
    }
}