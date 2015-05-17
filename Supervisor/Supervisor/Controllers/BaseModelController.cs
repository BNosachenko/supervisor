
namespace Supervisor.Controllers
{
    using Supervisor.Models;
    using System.Web.Http;

    public class BaseModelController<T> : ApiController where T : BaseModel
    {

    }
}
