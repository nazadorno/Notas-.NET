using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ejercicio_Notas.Models {
    public class Nota {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Titulo { get; set; }
        public string Cuerpo { get; set; }
        public Usuario Creador { get; set; }
    }
}