using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockManagerPro
{
    public partial class Plantilla : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                verifySession();
            }
        }

        public void verifySession()
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        protected void button_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session["user"] = null;
            Response.Redirect("~/Login.aspx");
        }
    }
}