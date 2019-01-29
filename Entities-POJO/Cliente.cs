using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_POJO
{
    public class Cliente : BaseEntity
    {
        public Cliente() {
        }

        public string nombre { get; set; }
        public string identificacion { get; set; }
        public string direccion { get; set; }

    }
}
