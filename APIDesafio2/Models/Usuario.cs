using System.ComponentModel.DataAnnotations;

namespace APIDesafio2.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        [Required]
        [MinLength(3), MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        public string Contraseña { get; set; }

        public int RolId { get; set; }
        public Rol Rol { get; set; }
    }
}
