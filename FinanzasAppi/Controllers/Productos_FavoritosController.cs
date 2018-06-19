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
    public class Productos_FavoritosController : ApiController
    {
        private ModelDB db = new ModelDB();

        // GET: api/Productos_Favoritos
        public IQueryable<Producto_Favorito> GetProducto_Favorito()
        {
            return db.Producto_Favorito;
        }

        // GET: api/Productos_Favoritos/5
        [ResponseType(typeof(Producto_Favorito))]
        public IHttpActionResult GetProducto_Favorito(int id)
        {
            Producto_Favorito producto_Favorito = db.Producto_Favorito.Find(id);
            if (producto_Favorito == null)
            {
                return NotFound();
            }

            return Ok(producto_Favorito);
        }

        // PUT: api/Productos_Favoritos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProducto_Favorito(int id, Producto_Favorito producto_Favorito)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != producto_Favorito.productofavoritoid)
            {
                return BadRequest();
            }

            db.Entry(producto_Favorito).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Producto_FavoritoExists(id))
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

        // POST: api/Productos_Favoritos
        [ResponseType(typeof(Producto_Favorito))]
        public IHttpActionResult PostProducto_Favorito(Producto_Favorito producto_Favorito)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Producto_Favorito.Add(producto_Favorito);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = producto_Favorito.productofavoritoid }, producto_Favorito);
        }

        // DELETE: api/Productos_Favoritos/5
        [ResponseType(typeof(Producto_Favorito))]
        public IHttpActionResult DeleteProducto_Favorito(int id)
        {
            Producto_Favorito producto_Favorito = db.Producto_Favorito.Find(id);
            if (producto_Favorito == null)
            {
                return NotFound();
            }

            db.Producto_Favorito.Remove(producto_Favorito);
            db.SaveChanges();

            return Ok(producto_Favorito);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Producto_FavoritoExists(int id)
        {
            return db.Producto_Favorito.Count(e => e.productofavoritoid == id) > 0;
        }
    }
}