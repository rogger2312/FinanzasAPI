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
    public class Ubicaciones_de_Negocios_PequeñosController : ApiController
    {
        private ModelDB db = new ModelDB();

        // GET: api/Ubicaciones_de_Negocios_Pequeños
        public IQueryable<Ubicacion_de_Negocio_Pequeño> GetUbicacion_de_Negocio_Pequeño()
        {
            return db.Ubicacion_de_Negocio_Pequeño;
        }

        // GET: api/Ubicaciones_de_Negocios_Pequeños/5
        [ResponseType(typeof(Ubicacion_de_Negocio_Pequeño))]
        public IHttpActionResult GetUbicacion_de_Negocio_Pequeño(int id)
        {
            Ubicacion_de_Negocio_Pequeño ubicacion_de_Negocio_Pequeño = db.Ubicacion_de_Negocio_Pequeño.Find(id);
            if (ubicacion_de_Negocio_Pequeño == null)
            {
                return NotFound();
            }

            return Ok(ubicacion_de_Negocio_Pequeño);
        }

        // PUT: api/Ubicaciones_de_Negocios_Pequeños/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUbicacion_de_Negocio_Pequeño(int id, Ubicacion_de_Negocio_Pequeño ubicacion_de_Negocio_Pequeño)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ubicacion_de_Negocio_Pequeño.negocioid)
            {
                return BadRequest();
            }

            db.Entry(ubicacion_de_Negocio_Pequeño).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Ubicacion_de_Negocio_PequeñoExists(id))
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

        // POST: api/Ubicaciones_de_Negocios_Pequeños
        [ResponseType(typeof(Ubicacion_de_Negocio_Pequeño))]
        public IHttpActionResult PostUbicacion_de_Negocio_Pequeño(Ubicacion_de_Negocio_Pequeño ubicacion_de_Negocio_Pequeño)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ubicacion_de_Negocio_Pequeño.Add(ubicacion_de_Negocio_Pequeño);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ubicacion_de_Negocio_Pequeño.negocioid }, ubicacion_de_Negocio_Pequeño);
        }

        // DELETE: api/Ubicaciones_de_Negocios_Pequeños/5
        [ResponseType(typeof(Ubicacion_de_Negocio_Pequeño))]
        public IHttpActionResult DeleteUbicacion_de_Negocio_Pequeño(int id)
        {
            Ubicacion_de_Negocio_Pequeño ubicacion_de_Negocio_Pequeño = db.Ubicacion_de_Negocio_Pequeño.Find(id);
            if (ubicacion_de_Negocio_Pequeño == null)
            {
                return NotFound();
            }

            db.Ubicacion_de_Negocio_Pequeño.Remove(ubicacion_de_Negocio_Pequeño);
            db.SaveChanges();

            return Ok(ubicacion_de_Negocio_Pequeño);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Ubicacion_de_Negocio_PequeñoExists(int id)
        {
            return db.Ubicacion_de_Negocio_Pequeño.Count(e => e.negocioid == id) > 0;
        }
    }
}