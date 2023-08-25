using System.ComponentModel.DataAnnotations;

namespace ApiRegistro2023.Models
{
    public class Empleado
    {
        [Key]
        public int codigo { get; set; }
        //x= obj.codigo --> get
        //obj.codigo=5 --> set
        public string nombre { get; set; }
        public string apellidopaterno { get; set; }
        public string apellidomaterno { get; set; }
        public DateTime fecha { get; set; }
        public string dni { get; set; }
        public string sexo { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string correo { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public bool estado { get; set; }
        public Rol rol { get; set; }
        public Dirección dirección { get; set; }
    }
}
