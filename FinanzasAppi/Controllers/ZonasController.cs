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
    public class ZonasController : ApiController
    {
        private ModelDB db = new ModelDB();

        // GET: api/Zonas
        public IQueryable<Zona> GetZona()
        {
            return db.Zona;
        }

        // GET: api/Zonas/5
        [ResponseType(typeof(Zona))]
        public IHttpActionResult GetZona(int id)
        {
            Zona zona = db.Zona.Find(id);
            if (zona == null)
            {
                return NotFound();
            }

            return Ok(zona);
        }

        // PUT: api/Zonas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutZona(int id, Zona zona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != zona.zonaid)
            {
                return BadRequest();
            }

            db.Entry(zona).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZonaExists(id))
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

        // POST: api/Zonas
        [ResponseType(typeof(Zona))]
        public IHttpActionResult PostZona(Zona zona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Zona.Add(zona);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = zona.zonaid }, zona);
        }

        // DELETE: api/Zonas/5
        [ResponseType(typeof(Zona))]
        public IHttpActionResult DeleteZona(int id)
        {
            Zona zona = db.Zona.Find(id);
            if (zona == null)
            {
                return NotFound();
            }

            db.Zona.Remove(zona);
            db.SaveChanges();

            return Ok(zona);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ZonaExists(int id)
        {
            return db.Zona.Count(e => e.zonaid == id) > 0;
        }
    }
}