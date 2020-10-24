using System;
using System.ComponentModel.DataAnnotations;

namespace Tutorial_Api.Models
{
    public class Visitas
    {
        [Key]
        public int VisitaId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Nombres { get; set;}
    }
}