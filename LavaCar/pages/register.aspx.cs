using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using BusinessLogic;

namespace LavaCar.pages
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadServices();
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        private void loadServices()
        {
            List<Servicio_E> listE = new List<Servicio_E>();
            new Servicio_BL().getAllServices(listE);

            foreach (Servicio_E servicio in listE)
            {
                ListItem li = new ListItem();
                li.Value = "" + servicio.ID_Servicio;
                li.Text = servicio.Descripcion;
                cBoxServices.Items.Add(li);
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            List<int> servicesSelected = new List<int>();

            if (IsValid)
            {
                if (verifyRegistrationInfo(servicesSelected))
                {
                    lblErrorMessage.Visible = false;
                    Vehiculo_E vehiculoE = new Vehiculo_E();
                    vehiculoE.Duenno = txtName.Text;
                    vehiculoE.Placa = txtCarRegistration.Text;
                    vehiculoE.Marca = txtBrand.Text;

                    new Vehiculo_BL().registerVehicle(vehiculoE, servicesSelected);

                    Response.Redirect("index.aspx");
                }
                else
                {
                    lblErrorMessage.Visible = true;
                }
            }
        }

        private Boolean verifyRegistrationInfo(List<int> services)
        {
            foreach(ListItem li in cBoxServices.Items)
            {
                if (li.Selected)
                {
                    services.Add(int.Parse(li.Value));
                }
            }

            if(services.Count != 0)
            {
                return true;
            }

            return false;
        }
    }
}