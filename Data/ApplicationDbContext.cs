using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace grupo_rojo_repository.Data;
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
    

    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "Nombre")]
        public string? Nombre { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        public string? Apellido { get; set; }

        [Required]
        [Display(Name = "Documento")]
        public string? Documento { get; set; }

        [Required]
        [Display(Name = "Domicilio")]
        public string? Domicilio { get; set; }
    }

    public DbSet<grupo_rojo_repository.Models.Producto> DataProducto {get; set; }
}

