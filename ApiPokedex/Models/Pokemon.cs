using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiPokedex.Models
{
    public class Pokemon
    {
        [Key]
        public int PokemonId { get; set; }
        public string Nombre { get; set; }
        public int Nivel { get; set; }
    }
}