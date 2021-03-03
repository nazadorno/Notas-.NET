using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio_Notas.Models
{
    public class Usuario
    {
        [Key]
        public string Mail { get; set; }
        [Required]
        public string Nombre { get; set; }

        public List<Nota> Notas { get; set; }
    }
}