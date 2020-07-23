using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LavaCar
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegiste_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }

        protected void btnServices_Click(object sender, EventArgs e)
        {
            Response.Redirect("services.aspx");
        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("reports.aspx");
        }
    }
}