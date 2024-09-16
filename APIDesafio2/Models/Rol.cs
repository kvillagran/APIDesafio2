using System.ComponentModel.DataAnnotations;

namespace APIDesafio2.Models
{
    public class Rol
    {
        public int RolId { get; set; }

        [Required]
        [MinLength(3), MaxLength(30)]
        public string Nombre { get; set; }

        public string? Descripcion { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<Permiso> Permisos { get; set; }
    }
}
