using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiPokedex.Models
{
    public class Entrenador
    {
        [Key]
        public int EntrenadorId { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}