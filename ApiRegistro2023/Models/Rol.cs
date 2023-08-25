using System.ComponentModel.DataAnnotations;

namespace ApiRegistro2023.Models
{
    public class Rol
    {
        // Clave Primary --> key

        [Key]
        public int codrol { get; set; }
        public string nomrol { get; set; }
        public bool estrol { get; set; }
    }
}
