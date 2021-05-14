using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRUEBADEPROYECTO.Models
{
    [Table("Tarjetas")]
    public class Tarjeta
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, Display(Name = "Número de tarjeta")]
        public string NumTarjeta { get; set; }
    }
}
