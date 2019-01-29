using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Proyecto : BaseEntity
    {
        public int IdProyecto { get; set; }
        public string IdUsuario { get; set; }
        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Industria { get; set; }
        public string Descripcion { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFinal { get; set; }

        public Proyecto()
        {
        }

        public Proyecto(string idUsuario, string idCliente, string nombre, string industria, string descripcion, string fechaInicio, string fechaFinal)
        {
            IdUsuario = idUsuario;
            IdCliente = idCliente;
            Nombre = nombre;
            Industria = industria;
            Descripcion = descripcion;
            FechaInicio = fechaInicio;
            FechaFinal = fechaFinal;
        }
    }
}
