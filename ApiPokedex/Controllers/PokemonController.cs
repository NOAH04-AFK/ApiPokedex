using ApiPokedex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiPokedex.Controllers
{
    public class PokemonController : ApiController
    {
        private PokedexContext db = new PokedexContext();

        //GET: api/Pokemon

        public IHttpActionResult Get() => Ok(db.Pokemons.ToList());

        //GET: api/Pokemon/5

        public IHttpActionResult Get(int id)
        {
            var m = db.Pokemons.Find(id);
            return m == null ? (IHttpActionResult)NotFound() : Ok(m);
        }

        //POST: api/Pokemon
        public IHttpActionResult Post(Pokemon mat)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            db.Pokemons.Add(mat);
            db.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = mat.PokemonId }, mat);
        }

        //PUT: api/Pokemon/5

        public IHttpActionResult Put(int id, Pokemon mat)
        {
            var m = db.Pokemons.Find(id);
            if (m == null) return NotFound();
            m.Nombre = mat.Nombre; m.Nivel = mat.Nivel;
            db.SaveChanges();
            return Ok(m);
        }

        //DELETE: api/Pokemon/5
        public IHttpActionResult Delete(int id)
        {
            var m = db.Pokemons.Find(id);
            if (m == null) return NotFound();
            db.Pokemons.Remove(m);
            db.SaveChanges();
            return Ok("Pokemon eliminado correctamente");
        }

        protected override void Dispose(bool disposing)
        {
            if(disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}
