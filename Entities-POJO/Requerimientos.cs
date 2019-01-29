using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Requerimientos : BaseEntity
    {

        public int ID_REQUERIMIENTO { get; set; }
        public String CODIGO { get; set; }
        public double PRIORIDAD { get; set; }
        public String DESCRIPCION { get; set; }
        public int ID_PROYECTO { get; set; }
        public Boolean ESTADO { get; set; }

        public Requerimientos()
        {
        }

        public Requerimientos(String[] infoArray)
        {
            if (infoArray != null && infoArray.Length >= 4)
            {
                ID_REQUERIMIENTO = Int32.Parse(infoArray[0]);
                CODIGO = infoArray[1];
                PRIORIDAD = Double.Parse(infoArray[2]);
                DESCRIPCION = infoArray[3];
                ID_PROYECTO = Int32.Parse(infoArray[4]);
                ESTADO = Boolean.Parse(infoArray[5]);
            }
        }

    }
}
