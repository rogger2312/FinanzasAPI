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
using FinanzasAppi.Models;

namespace FinanzasAppi.Controllers
{
    public class FlujosController : ApiController
    {
        private ModelDB db = new ModelDB();

        // GET: api/Flujos
        public IQueryable<Flujo> GetFlujo()
        {
            return db.Flujo;
        }

        // GET: api/Flujos/5
        [ResponseType(typeof(Flujo))]
        public IHttpActionResult GetFlujo(int id)
        {
            Flujo flujo = db.Flujo.Find(id);
            if (flujo == null)
            {
                return NotFound();
            }

            return Ok(flujo);
        }

        // PUT: api/Flujos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFlujo(int id, Flujo flujo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != flujo.flujoid)
            {
                return BadRequest();
            }

            db.Entry(flujo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlujoExists(id))
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

        // POST: api/Flujos
        [ResponseType(typeof(Flujo))]
        public IHttpActionResult PostFlujo(Flujo flujo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Flujo.Add(flujo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = flujo.flujoid }, flujo);
        }

        // DELETE: api/Flujos/5
        [ResponseType(typeof(Flujo))]
        public IHttpActionResult DeleteFlujo(int id)
        {
            Flujo flujo = db.Flujo.Find(id);
            if (flujo == null)
            {
                return NotFound();
            }

            db.Flujo.Remove(flujo);
            db.SaveChanges();

            return Ok(flujo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FlujoExists(int id)
        {
            return db.Flujo.Count(e => e.flujoid == id) > 0;
        }
    }
}