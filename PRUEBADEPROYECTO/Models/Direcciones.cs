using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRUEBADEPROYECTO.Models
{
    [Table("Direction")]
    public class Direcciones
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Required, Display(Name = "Dirección")]
        public string Direccion { get; set; }
    }
}
