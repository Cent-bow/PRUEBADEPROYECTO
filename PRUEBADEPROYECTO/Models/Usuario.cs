using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRUEBADEPROYECTO.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Required, Display(Name = "Nombre completo")]
        public string NombreCompleto { get; set; }

        [Required, Display(Name = "Número de télefono")]
        public string NumeroTelefono { get; set; }

        [Display(Name = "Código postal")]
        public string CodigoPostal { get; set; }


    }
}
