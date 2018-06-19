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
    public class LocalesController : ApiController
    {
        private ModelDB db = new ModelDB();

        // GET: api/Locales
        public IQueryable<Local> GetLocal()
        {
            return db.Local;
        }

        // GET: api/Locales/5
        [ResponseType(typeof(Local))]
        public IHttpActionResult GetLocal(int id)
        {
            Local local = db.Local.Find(id);
            if (local == null)
            {
                return NotFound();
            }

            return Ok(local);
        }

        // PUT: api/Locales/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLocal(int id, Local local)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != local.localid)
            {
                return BadRequest();
            }

            db.Entry(local).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocalExists(id))
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

        // POST: api/Locales
        [ResponseType(typeof(Local))]
        public IHttpActionResult PostLocal(Local local)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Local.Add(local);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = local.localid }, local);
        }

        // DELETE: api/Locales/5
        [ResponseType(typeof(Local))]
        public IHttpActionResult DeleteLocal(int id)
        {
            Local local = db.Local.Find(id);
            if (local == null)
            {
                return NotFound();
            }

            db.Local.Remove(local);
            db.SaveChanges();

            return Ok(local);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LocalExists(int id)
        {
            return db.Local.Count(e => e.localid == id) > 0;
        }
    }
}