using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;

namespace BusinessLogic
{
    public class Vehiculo_BL
    {
        public void registerVehicle(Vehiculo_E vehiculoE, List<int> servicesIdList)
        {
            new Vehiculo_DA().addVehicle(vehiculoE);

            new Vehiculo_Servicio_DA().addGroupServicesToVehicle(vehiculoE.ID_Vehiculo, servicesIdList);
        }

        public List<Vehiculo_E> getVehiclesByService(int idService)
        {
            List<int> listIDs = new List<int>();
            listIDs = new Vehiculo_Servicio_DA().getVehiclesIdByService(idService);

            return new Vehiculo_DA().getVehiclesByService(listIDs);
        }
        
    }
}
