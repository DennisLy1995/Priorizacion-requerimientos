using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class CasoDeUso : BaseEntity
    {
        public String CODIGO { get; set; }
        public int ID_PROYECTO { get; set; }
        public float PRIORIDAD { get; set; }
        public String NOMBRE { get; set; }
        public String DESCRIPCION { get; set; }


        public CasoDeUso()
        {

        }


        

    }
}
