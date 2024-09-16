using System.ComponentModel.DataAnnotations;

namespace APIDesafio2.DTOs
{
    public class PermisoCreateDTO
    {
        [Required]
        [MinLength(3), MaxLength(50)]
        public string Nombre { get; set; }

        public string? Descripcion { get; set; }
    }

}
