using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;

namespace BusinessLogic
{
    public class Servicio_BL
    {
        public void addNewService(Servicio_E servicioE)
        {
            new Servicio_DA().addService(servicioE);
        }

        public void deleteService(Servicio_E servicioE)
        {
            new Servicio_DA().deleteService(servicioE);
        }

        public void updateService(Servicio_E servicioE)
        {
            new Servicio_DA().updateService(servicioE);
        }

        public void getService(Servicio_E servicioE)
        {
            new Servicio_DA().getService(servicioE);
        }

        public void getAllServices(List<Servicio_E> listE)
        {
            new Servicio_DA().getAllServices(listE);
        }
    }
}
