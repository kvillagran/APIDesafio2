using System.ComponentModel.DataAnnotations;

namespace APIDesafio2.Models
{
    public class Permiso
    {
        public int PermisoId { get; set; }

        [Required]
        [MinLength(3), MaxLength(50)]
        public string Nombre { get; set; }

        public string? Descripcion { get; set; }

        public ICollection<Rol> Roles { get; set; }
    }
}
