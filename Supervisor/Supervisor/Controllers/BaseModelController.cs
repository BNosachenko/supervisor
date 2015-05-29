
namespace Supervisor.Controllers
{
    using Supervisor.Context;
    using Supervisor.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Http;
    using System.Data.Entity;
    using System.Linq;
    using System;
    using System.Data.Entity.Infrastructure;


    public class BaseModelController<T> : ApiController where T : BaseModel
    {
        private SupervisorContext ctx;

        public BaseModelController(SupervisorContext ctx)
        {
            this.ctx = ctx;
        }

        [HttpGet]
        public async Task<IList<T>> Get()
        {
            return await this.ctx.Set<T>().ToListAsync();
        }

        [HttpGet]
        public async Task<T> Get(Guid id)
        {
            return await this.ctx.Set<T>().SingleAsync(x => x.Id.Equals(id));
        }

        [HttpPost]
        public async Task<IHttpActionResult> Post(T newEntity)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            this.ctx.Set<T>().Add(newEntity);
            await this.ctx.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<IHttpActionResult> Post(Guid id, T newEntity)
        {
            if (!ModelState.IsValid || id.Equals(Guid.Empty))
            {
                return BadRequest();
            }

            var entity = await this.ctx.Set<T>().SingleAsync(x => x.Id.Equals(id));
            entity = newEntity;
            await this.ctx.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task<IHttpActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid || id.Equals(Guid.Empty))
            {
                return BadRequest();
            }

            var entity = await this.Get(id);
            if(entity == null)
            {
                return Ok();
            }

            DbEntityEntry dbEntityEntry = ctx.Entry<T>(entity);
            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                ctx.Set<T>().Attach(entity);
                ctx.Set<T>().Remove(entity);
            }

            await this.ctx.SaveChangesAsync();
            return Ok();
        }
    }
}
