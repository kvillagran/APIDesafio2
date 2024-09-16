using System.ComponentModel.DataAnnotations;

namespace APIDesafio2.DTOs
{
    public class UsuarioCreateDTO
    {
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(8)]
        public string Contraseña { get; set; }

        // Solo el ID del rol
        public int RolId { get; set; }
    }

}
