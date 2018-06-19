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
    public class Flujos_FijosController : ApiController
    {
        private ModelDB db = new ModelDB();

        // GET: api/Flujos_Fijos
        public IQueryable<Flujo_Fijo> GetFlujo_Fijo()
        {
            return db.Flujo_Fijo;
        }

        // GET: api/Flujos_Fijos/5
        [ResponseType(typeof(Flujo_Fijo))]
        public IHttpActionResult GetFlujo_Fijo(int id)
        {
            Flujo_Fijo flujo_Fijo = db.Flujo_Fijo.Find(id);
            if (flujo_Fijo == null)
            {
                return NotFound();
            }

            return Ok(flujo_Fijo);
        }

        // PUT: api/Flujos_Fijos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFlujo_Fijo(int id, Flujo_Fijo flujo_Fijo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != flujo_Fijo.flujofijoid)
            {
                return BadRequest();
            }

            db.Entry(flujo_Fijo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Flujo_FijoExists(id))
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

        // POST: api/Flujos_Fijos
        [ResponseType(typeof(Flujo_Fijo))]
        public IHttpActionResult PostFlujo_Fijo(Flujo_Fijo flujo_Fijo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Flujo_Fijo.Add(flujo_Fijo);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = flujo_Fijo.flujofijoid }, flujo_Fijo);
        }

        // DELETE: api/Flujos_Fijos/5
        [ResponseType(typeof(Flujo_Fijo))]
        public IHttpActionResult DeleteFlujo_Fijo(int id)
        {
            Flujo_Fijo flujo_Fijo = db.Flujo_Fijo.Find(id);
            if (flujo_Fijo == null)
            {
                return NotFound();
            }

            db.Flujo_Fijo.Remove(flujo_Fijo);
            db.SaveChanges();

            return Ok(flujo_Fijo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Flujo_FijoExists(int id)
        {
            return db.Flujo_Fijo.Count(e => e.flujofijoid == id) > 0;
        }
    }
}