using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using BusinessLogic;
using System.Web.UI.HtmlControls;

namespace LavaCar.pages
{
    public partial class reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadServices();
            }
        }

        private void loadServices()
        {
            List<Servicio_E> listE = new List<Servicio_E>();
            new Servicio_BL().getAllServices(listE);

            ListItem i;

            foreach (Servicio_E se in listE)
            {
                i = new ListItem(se.Descripcion, se.ID_Servicio.ToString());
                ddlServices.Items.Add(i);
            }

            i = new ListItem("Seleccionar", "0");
            i.Selected = true;
            i.Enabled = false;
            ddlServices.Items.Add(i);
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void loadForm(object sender, EventArgs e)
        {
            string idService = ddlServices.SelectedItem.Value;

            List<Vehiculo_E> listE = new List<Vehiculo_E>();
            listE = new Vehiculo_BL().getVehiclesByService(int.Parse(idService));

            foreach (Vehiculo_E ve in listE)
            {
                Label txNumber = new Label ();
                txNumber.Text = ve.ID_Vehiculo.ToString();

                HtmlGenericControl numberDiv = new HtmlGenericControl("div");
                numberDiv.Attributes.Add("class", "service serviceLabel");
                numberDiv.Controls.Add(txNumber);

                Label txCarRegis = new Label();
                txCarRegis.Text = ve.Placa;

                HtmlGenericControl regisDiv = new HtmlGenericControl("div");
                regisDiv.Attributes.Add("class", "service serviceLabel");
                regisDiv.Controls.Add(txCarRegis);

                Label txBrand = new Label();
                txBrand.Text = ve.Marca;

                HtmlGenericControl brandDiv = new HtmlGenericControl("div");
                brandDiv.Attributes.Add("class", "service serviceLabel");
                brandDiv.Controls.Add(txBrand);

                Label txName = new Label();
                txName.Text = ve.Duenno;

                HtmlGenericControl nameDiv = new HtmlGenericControl("div");
                nameDiv.Attributes.Add("class", "service serviceLabel");
                nameDiv.Controls.Add(txName);

                HtmlGenericControl div = new HtmlGenericControl("div");

                div.Attributes.Add("class", "eachService");
                div.Controls.Add(numberDiv);
                div.Controls.Add(regisDiv);
                div.Controls.Add(brandDiv);
                div.Controls.Add(nameDiv);

                HtmlGenericControl divLine = new HtmlGenericControl("div");
                divLine.Attributes.Add("class", "dLine");

                div.Controls.Add(divLine);

                containerService.Controls.Add(div);

            }
        }
    }
}