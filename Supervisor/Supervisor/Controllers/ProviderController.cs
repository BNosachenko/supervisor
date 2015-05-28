
namespace Supervisor.Controllers
{
    using Supervisor.Context;
    using Supervisor.Models;
    using System;
    //using System.Web.Http;
    using System.Web.Mvc;

    public class ProviderController : BaseModelController<ProvidedGoodsModel>
    {
        private Contexts db = new Contexts("Contexts");
        // GET: Agent
        public string GetProvider()
        {
            String providers = db.Providers.ToString();
            return providers;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ProviderModel Create([Bind(Include = "Address,Name,Phone")] ProviderModel provider)
        {
            if (ModelState.IsValid)
            {
                db.Providers.Add(provider);
                db.SaveChanges();
                return provider;
            }
            return provider;
        }
    }
}
