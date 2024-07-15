using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BarberShop.DoMain;
using BarberShop.Entity.DataContexts;

namespace BarberShop.Api.Controllers
{
    [RoutePrefix("api/guru/public")]
    public class CargoController : ApiController
    {
        private BarberShopDataContext db = new BarberShopDataContext();

        [Route("cargo")]
        public HttpResponseMessage GetCargo()
        {
            var result = db.Cargo.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        /*
        // GET: api/Cargo
        public IQueryable<Cargo> GetCargo()
        {
            return db.Cargo;
        }

        // GET: api/Cargo/5
        [ResponseType(typeof(Cargo))]
        public IHttpActionResult GetCargo(int id)
        {
            Cargo cargo = db.Cargo.Find(id);
            if (cargo == null)
            {
                return NotFound();
            }

            return Ok(cargo);
        }

        // PUT: api/Cargo/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCargo(int id, Cargo cargo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cargo.Id)
            {
                return BadRequest();
            }

            db.Entry(cargo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CargoExists(id))
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

        // POST: api/Cargo
        [ResponseType(typeof(Cargo))]
        public IHttpActionResult PostCargo(Cargo cargo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cargo.Add(cargo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cargo.Id }, cargo);
        }

        // DELETE: api/Cargo/5
        [ResponseType(typeof(Cargo))]
        public IHttpActionResult DeleteCargo(int id)
        {
            Cargo cargo = db.Cargo.Find(id);
            if (cargo == null)
            {
                return NotFound();
            }

            db.Cargo.Remove(cargo);
            db.SaveChanges();

            return Ok(cargo);
        }
        */
        protected override void Dispose(bool disposing)
        {
                db.Dispose();
        }

        /*private bool CargoExists(int id)
        {
            return db.Cargo.Count(e => e.Id == id) > 0;
        }*/
    }
}