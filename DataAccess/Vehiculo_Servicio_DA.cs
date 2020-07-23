using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    public class Vehiculo_Servicio_DA
    {
        public void addVeSe(int idVe, int idSe)
        {
            using (lavacarEntities db = new lavacarEntities())
            {
                Vehiculo_Servicio vs = new Vehiculo_Servicio();
                vs.ID_Vehiculo = idVe;
                vs.ID_Servicio = idSe;

                db.Vehiculo_Servicio.Add(vs);
                db.SaveChanges();
            }
        }

        public void addGroupServicesToVehicle(int idVehicle, List<int> idServices)
        {
            using (lavacarEntities db = new lavacarEntities())
            {
                foreach(int id in idServices)
                {
                    Vehiculo_Servicio vs = new Vehiculo_Servicio();
                    vs.ID_Vehiculo = idVehicle;
                    vs.ID_Servicio = id;

                    db.Vehiculo_Servicio.Add(vs);
                    db.SaveChanges();
                }
            }
        }

        public List<int> getVehiclesIdByService(int idService)
        {
            List<int> listIDs = new List<int>();

            using (lavacarEntities db = new lavacarEntities())
            {
                var listVeSe = db.Vehiculo_Servicio;
                foreach (var veSe in listVeSe)
                {
                    if (veSe.ID_Servicio == idService)
                    {
                        listIDs.Add(veSe.ID_Vehiculo);
                    }
                }
            }
            return listIDs;
        }
    }
}
