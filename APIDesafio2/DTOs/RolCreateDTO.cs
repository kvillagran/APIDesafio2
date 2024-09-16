using System.ComponentModel.DataAnnotations;

namespace APIDesafio2.DTOs
{
    public class RolCreateDTO
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<int> PermisoIds { get; set; } // Solo los IDs de los permisos
    }


}
