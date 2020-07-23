using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    public class Servicio_DA
    {

        public void addService(Servicio_E servicioE)
        {
            using (lavacarEntities db = new lavacarEntities())
            {
                Servicio se = new Servicio();
                se.Descripción = servicioE.Descripcion;
                se.Monto = servicioE.Monto;

                db.Servicios.Add(se);
                db.SaveChanges();
                
            }
        }

        public void deleteService(Servicio_E servicioE)
        {
            using (lavacarEntities db = new lavacarEntities())
            {
                Servicio se = db.Servicios.Find(servicioE.ID_Servicio);

                db.Servicios.Remove(se);
                db.SaveChanges();
            }
        }

        public void updateService(Servicio_E servicioE)
        {
            using (lavacarEntities db = new lavacarEntities())
            {
                Servicio se = db.Servicios.Find(servicioE.ID_Servicio);
                se.Descripción = servicioE.Descripcion;
                se.Monto = servicioE.Monto;

                db.Entry(se).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void getService(Servicio_E servicioE)
        {
            using (lavacarEntities db = new lavacarEntities())
            {
                Servicio se = db.Servicios.Find(servicioE.ID_Servicio);
                servicioE.Descripcion = se.Descripción;
                servicioE.Monto = se.Monto;
            }
        }

        public void getAllServices(List<Servicio_E> listE)
        {
            using (lavacarEntities db = new lavacarEntities())
            {
                var listS = db.Servicios;
                foreach(var se in listS)
                {
                    listE.Add(new Servicio_E(se.ID_Servicio, se.Descripción, se.Monto));
                }
            }
        }
    }
}
