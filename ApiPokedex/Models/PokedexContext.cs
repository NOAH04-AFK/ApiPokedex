using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiPokedex.Models
{
    public class PokedexContext : DbContext
    {
        public PokedexContext() : base("name=PokedexConnection"){}
        public DbSet<Entrenador> Entrenadores { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
    }
}