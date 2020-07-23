using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Vehiculo_E
    {
        public int ID_Vehiculo { get; set; }
        public String Placa { get; set; }
        public String Duenno { get; set; }
        public String Marca { get; set; }

        public Vehiculo_E()
        {

        }

        public Vehiculo_E(int id_vehiculo, String placa, String duenno, String marca)
        {
            this.ID_Vehiculo = id_vehiculo;
            this.Placa = placa;
            this.Duenno = duenno;
            this.Marca = marca;
        }
    }
}
