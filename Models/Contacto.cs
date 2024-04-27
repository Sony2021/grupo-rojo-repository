using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace grupo_rojo_repository.Models
{
    [Table("t_contacto")]
    public class Contacto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         public string? Nombre { get; set; }
         public string? Email { get; set; }

         public string? Mensaje { get; set; }

         public string? category { get; set; }

    }
}