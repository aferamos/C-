using BarberShop.DoMain;
using BarberShop.Entity.DataContexts;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace BarberShop.Api.Controllers
{
    [RoutePrefix("api/guru/public")]
    public class AgendaController : ApiController
    {
        
        private BarberShopDataContext db = new BarberShopDataContext();
        
        [Route("agenda")]
        public HttpResponseMessage GetAgenda()
        {
            var result = db.Agenda.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, result);
            
        }
      /*
        // GET: api/Agenda
        public IQueryable<Agenda> GetAgendas()
        {
            return db.Agenda;
        }

        // GET: api/Agenda/5
        [ResponseType(typeof(Agenda))]
        public IHttpActionResult GetAgenda(int id)
        {
            Agenda agenda = db.Agenda.Find(id);
            if (agenda == null)
            {
                return NotFound();
            }

            return Ok(agenda);
        }

        // PUT: api/Agenda/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAgenda(int id, Agenda agenda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != agenda.Id)
            {
                return BadRequest();
            }

            db.Entry(agenda).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgendaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Agenda
        [ResponseType(typeof(Agenda))]
        public IHttpActionResult PostAgenda(Agenda agenda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Agenda.Add(agenda);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = agenda.Id }, agenda);
        }

        // DELETE: api/Agenda/5
        [ResponseType(typeof(Agenda))]
        public IHttpActionResult DeleteAgenda(int id)
        {
            Agenda agenda = db.Agenda.Find(id);
            if (agenda == null)
            {
                return NotFound();
            }

            db.Agenda.Remove(agenda);
            db.SaveChanges();

            return Ok(agenda);
        }
        */
        protected override void Dispose(bool disposing)
        {
                db.Dispose();
        }
        /*
        private bool AgendaExists(int id)
        {
            return db.Agenda.Count(e => e.Id == id) > 0;
        }*/
    }
}