
namespace Supervisor
{
    using Supervisor.Context;
    using System.Configuration;
    using System.Data.Entity;
    using System.Web.Http;

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            Database.SetInitializer(new CreateDatabaseIfNotExists<Contexts>());
            using (var ctx = new Contexts(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString))
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                ctx.Configuration.ProxyCreationEnabled = false;
            }
        }
    }
}
