using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace grupo_rojo_repository.Models
{
    [Table("t_producto")]
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [NotNull]
        public string? Articulo { get; set; }  
        [NotNull]
        public string? Lote { get; set; }
        [NotNull]
        public string? Composición { get; set; }
        [NotNull]
        public decimal Ancho { get; set; }
        [NotNull]
        public int Gramaje { get; set; }
        [NotNull]
        public string? Diseños { get; set; }
        [NotNull]
        public int CantidadTotal { get; set; }
        [NotNull]
        public string? Colores { get; set; }
        [NotNull]
        public decimal Precio { get; set; }
        [NotNull]
        public string? ImageURL { get; set; } 
    }
}
