using ApiPokedex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiPokedex.Controllers
{
    public class EntrenadorController : ApiController
    {
        private PokedexContext db = new PokedexContext();
        // GET: api/Entrenador
        public IHttpActionResult Get() => Ok(db.Entrenadores.ToList());

        //GET: api/Entrenador/5
        public IHttpActionResult Get(int id)
        {
            var e = db.Entrenadores.Find(id);
            return e == null ? (IHttpActionResult)NotFound() : Ok(e);
        }

        //POST: api/Entrenador
        public IHttpActionResult Post(Entrenador est)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            db.Entrenadores.Add(est);
            db.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = est.EntrenadorId }, est);
        }

        //PUT: api/Entrenador/5
        public IHttpActionResult Put(int id, Entrenador est)
        {
            var e = db.Entrenadores.Find(id);
            if (e == null) return NotFound();
            e.Nombre = est.Nombre; e.Edad = est.Edad;
            db.SaveChanges();
            return Ok(e);
        }

        //DELETE: api/Entrenador/5

        public IHttpActionResult Delete(int id)
        {
            var e = db.Entrenadores.Find(id);
            if (e == null) return NotFound();
            db.Entrenadores.Remove(e);
            db.SaveChanges();
            return Ok("Entrenador eliminado correctamente");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
      }
    }
