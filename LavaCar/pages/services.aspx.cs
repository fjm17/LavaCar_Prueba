using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Entities;
using BusinessLogic;
using System.ComponentModel;

namespace LavaCar.pages
{
    public partial class services : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            loadServices();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        private void loadServices()
        {
            List<Servicio_E> listE = new List<Servicio_E>();
            Servicio_BL servicioBL = new Servicio_BL();
            servicioBL.getAllServices(listE);

            foreach(Servicio_E se in listE)
            {
                TextBox txName = new TextBox();
                txName.ID = "txtName" + se.ID_Servicio;
                txName.Text = se.Descripcion;
                txName.Attributes.Add("runat", "server");

                HtmlGenericControl nameDiv = new HtmlGenericControl("div");
                nameDiv.Attributes.Add("class", "service");
                nameDiv.Controls.Add(txName);

                TextBox txPrice = new TextBox();
                txPrice.ID = "txtPrice" + se.ID_Servicio;
                txPrice.Text = se.Monto.ToString();
                txPrice.Attributes.Add("runat", "server");
                txPrice.Attributes.Add("type", "number");

                HtmlGenericControl priceDiv = new HtmlGenericControl("div");
                priceDiv.Attributes.Add("class", "service");
                priceDiv.Controls.Add(txPrice);

                Button btnUpd = new Button();
                btnUpd.ID = "btnUpd_" + se.ID_Servicio;
                btnUpd.Text = "Actualizar";
                btnUpd.Attributes.Add("class", "btn btn-info");
                btnUpd.Attributes.Add("runat", "server");
                btnUpd.Click += new EventHandler(updateService);
                
                HtmlGenericControl updateDiv = new HtmlGenericControl("div");
                updateDiv.Attributes.Add("class", "service");
                updateDiv.Controls.Add(btnUpd);

                HtmlGenericControl div = new HtmlGenericControl("div");

                div.Attributes.Add("class", "eachService");
                div.Controls.Add(nameDiv);
                div.Controls.Add(priceDiv);
                div.Controls.Add(updateDiv);

                containerS.Controls.Add(div);
            }
            addRow();

        }

        private void addRow()
        {
            TextBox txNa = new TextBox();
            txNa.ID = "newServiceName";
            txNa.Attributes.Add("runat", "server");
            HtmlGenericControl divName = new HtmlGenericControl("div");
            divName.Attributes.Add("class", "service");
            divName.Attributes.Add("requiered", "true");
            divName.Controls.Add(txNa);

            TextBox txPr = new TextBox();
            txPr.ID = "newServicePrice";
            txPr.Attributes.Add("runat", "server");
            txPr.Attributes.Add("type", "number");
            HtmlGenericControl divPrice = new HtmlGenericControl("div");
            divPrice.Attributes.Add("class", "service");
            divPrice.Controls.Add(txPr);

            Button btnAdd = new Button();
            btnAdd.ID = "btnAdd";
            btnAdd.Text = "Agregar";
            btnAdd.Attributes.Add("class", "btn btn-success");
            btnAdd.Attributes.Add("runat", "server");
            btnAdd.Click += new EventHandler(addService);
            HtmlGenericControl divAdd = new HtmlGenericControl("div");
            divAdd.Attributes.Add("class", "service");
            divAdd.Controls.Add(btnAdd);

            HtmlGenericControl div = new HtmlGenericControl("div");
            div.Attributes.Add("class", "eachService");
            div.Controls.Add(divName);
            div.Controls.Add(divPrice);
            div.Controls.Add(divAdd);

            containerS.Controls.Add(div);
        }


        protected void addService(object sender, EventArgs e)
        {
            TextBox tbName = (TextBox)FindControl("newServiceName");
            TextBox tbPrice = (TextBox)FindControl("newServicePrice");
            new Servicio_BL().addNewService(new Servicio_E(0, tbName.Text, int.Parse(tbPrice.Text)));

            containerS.InnerHtml = "";
            loadServices();

        }

        protected void updateService(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            String buttonId = b.ID;
            String[] val = buttonId.Split('_');
            int id = int.Parse(val[val.Length - 1]);

            TextBox tbName = (TextBox)FindControl("txtName" + id);
            String name = tbName.Text;
            TextBox tbPrice = (TextBox)FindControl("txtPrice" + id);
            int price = int.Parse(tbPrice.Text);

            new Servicio_BL().updateService(new Servicio_E(id, name, price));
            containerS.InnerHtml = "";
            loadServices();
        }

        protected void deleteService(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            String buttonId = b.ID;
            String[] val = buttonId.Split('_');
            int id = int.Parse(val[val.Length - 1]);

            new Servicio_BL().deleteService(new Servicio_E(id, "", 0));
            containerS.InnerHtml = "";
            loadServices();
        }
    }
}