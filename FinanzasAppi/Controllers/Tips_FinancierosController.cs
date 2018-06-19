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
    public class Tips_FinancierosController : ApiController
    {
        private ModelDB db = new ModelDB();

        // GET: api/Tips_Financieros
        public IQueryable<Tips_Financieros> GetTips_Financieros()
        {
            return db.Tips_Financieros;
        }

        // GET: api/Tips_Financieros/5
        [ResponseType(typeof(Tips_Financieros))]
        public IHttpActionResult GetTips_Financieros(int id)
        {
            Tips_Financieros tips_Financieros = db.Tips_Financieros.Find(id);
            if (tips_Financieros == null)
            {
                return NotFound();
            }

            return Ok(tips_Financieros);
        }

        // PUT: api/Tips_Financieros/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTips_Financieros(int id, Tips_Financieros tips_Financieros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tips_Financieros.tipsid)
            {
                return BadRequest();
            }

            db.Entry(tips_Financieros).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tips_FinancierosExists(id))
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

        // POST: api/Tips_Financieros
        [ResponseType(typeof(Tips_Financieros))]
        public IHttpActionResult PostTips_Financieros(Tips_Financieros tips_Financieros)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Tips_Financieros.Add(tips_Financieros);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tips_Financieros.tipsid }, tips_Financieros);
        }

        // DELETE: api/Tips_Financieros/5
        [ResponseType(typeof(Tips_Financieros))]
        public IHttpActionResult DeleteTips_Financieros(int id)
        {
            Tips_Financieros tips_Financieros = db.Tips_Financieros.Find(id);
            if (tips_Financieros == null)
            {
                return NotFound();
            }

            db.Tips_Financieros.Remove(tips_Financieros);
            db.SaveChanges();

            return Ok(tips_Financieros);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Tips_FinancierosExists(int id)
        {
            return db.Tips_Financieros.Count(e => e.tipsid == id) > 0;
        }
    }
}