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
    public class PessoasController : ApiController
    {
        private BarberShopDataContext db = new BarberShopDataContext();

        [Route("pessoa")]
        public HttpResponseMessage GetPessoa()
        {
            var result = db.Pessoa.ToList();
            return Request.CreateResponse(HttpStatusCode.OK, result);

        }
        /*
        // GET: api/Pessoas
        public IQueryable<Pessoa> GetPessoa()
        {
            return db.Pessoa;
        }

        // GET: api/Pessoas/5
        [ResponseType(typeof(Pessoa))]
        public IHttpActionResult GetPessoa(int id)
        {
            Pessoa pessoa = db.Pessoa.Find(id);
            if (pessoa == null)
            {
                return NotFound();
            }

            return Ok(pessoa);
        }

        // PUT: api/Pessoas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPessoa(int id, Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pessoa.Id)
            {
                return BadRequest();
            }

            db.Entry(pessoa).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PessoaExists(id))
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

        // POST: api/Pessoas
        [ResponseType(typeof(Pessoa))]
        public IHttpActionResult PostPessoa(Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pessoa.Add(pessoa);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pessoa.Id }, pessoa);
        }

        // DELETE: api/Pessoas/5
        [ResponseType(typeof(Pessoa))]
        public IHttpActionResult DeletePessoa(int id)
        {
            Pessoa pessoa = db.Pessoa.Find(id);
            if (pessoa == null)
            {
                return NotFound();
            }

            db.Pessoa.Remove(pessoa);
            db.SaveChanges();

            return Ok(pessoa);
        }
        */
        protected override void Dispose(bool disposing)
        {
                db.Dispose();
          
        }
        /*
        private bool PessoaExists(int id)
        {
            return db.Pessoa.Count(e => e.Id == id) > 0;
        }*/
    }
}