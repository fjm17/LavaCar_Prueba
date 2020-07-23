using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Servicio_E
    {
        public int ID_Servicio { get; set; }
        public String Descripcion { get; set; }
        public int Monto { get; set; }

        public Servicio_E()
        {

        }

        public Servicio_E(int id_servicio, String descripcion, int monto)
        {
            this.ID_Servicio = id_servicio;
            this.Descripcion = descripcion;
            this.Monto = monto;
        }
    }
}
