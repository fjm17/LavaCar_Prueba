using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess
{
    public class Vehiculo_DA
    {

        public void addVehicle(Vehiculo_E vehiculoE)
        {
            using(lavacarEntities db = new lavacarEntities())
            {
                Vehiculo ve = new Vehiculo();
                ve.Placa = vehiculoE.Placa;
                ve.Dueño = vehiculoE.Duenno;
                ve.Marca = vehiculoE.Marca;

                db.Vehiculoes.Add(ve);
                db.SaveChanges();

                Vehiculo veG = db.Vehiculoes.Where(v => v.Placa == vehiculoE.Placa).First();

                vehiculoE.ID_Vehiculo = veG.ID_Vehiculo;
            }
        }

        public void deleteVehicle(Vehiculo_E vehiculoE)
        {
            using (lavacarEntities db = new lavacarEntities())
            {
                Vehiculo ve = db.Vehiculoes.Find(vehiculoE.ID_Vehiculo);

                db.Vehiculoes.Remove(ve);
                db.SaveChanges();
            }
        }

        public void updateVehicle(Vehiculo_E vehiculoE)
        {
            using (lavacarEntities db = new lavacarEntities())
            {
                Vehiculo ve = db.Vehiculoes.Find(vehiculoE.ID_Vehiculo);
                ve.Placa = vehiculoE.Placa;
                ve.Dueño = vehiculoE.Duenno;
                ve.Marca = vehiculoE.Marca;

                db.Entry(ve).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void getVehicle(Vehiculo_E vehiculoE)
        {
            using (lavacarEntities db = new lavacarEntities())
            {
                Vehiculo ve = db.Vehiculoes.Find(vehiculoE.ID_Vehiculo);
                vehiculoE.Placa = ve.Placa;
                vehiculoE.Duenno = ve.Dueño;
                vehiculoE.Marca = ve.Marca;
            }
        }

        public void getAllVehicles(List<Vehiculo_E> listE)
        {
            using (lavacarEntities db = new lavacarEntities())
            {
                var listV = db.Vehiculoes;
                foreach(var ve in listV)
                {
                    listE.Add(new Vehiculo_E(ve.ID_Vehiculo, ve.Placa, ve.Dueño, ve.Marca));
                }
            }
        }

        public List<Vehiculo_E> getVehiclesByService(List<int> listIDs)
        {
            List<Vehiculo_E> listE = new List<Vehiculo_E>();

            using (lavacarEntities db = new lavacarEntities())
            {
                foreach (int id in listIDs)
                {
                    Vehiculo ve = db.Vehiculoes.Find(id);
                    listE.Add(new Vehiculo_E(ve.ID_Vehiculo, ve.Placa, ve.Dueño, ve.Marca));
                }
            }

            return listE;
        }
    }
}
