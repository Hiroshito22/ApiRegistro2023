using System.ComponentModel.DataAnnotations;

namespace ApiRegistro2023.Models
{
    public class Dirección
    {
        [Key]
        public int codigo { get; set; }
        public string prefijo { get; set; }
        public string nombre { get; set; }
        public string numero { get; set; }
        public string descripción { get; set; }
        public bool estado { get; set; }
    }
}
