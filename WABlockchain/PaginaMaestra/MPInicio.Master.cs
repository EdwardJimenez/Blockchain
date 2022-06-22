using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WABlockchain.PaginaMaestra
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Session["Rol"] == null)
                {
                    Session.Remove("Rol");
                    Response.Redirect("BLogin.aspx");
                }
            }
        }

        protected void btnCloseSession_Click(object sender, EventArgs e)
        {
            Session.Remove("Rol");
            Response.Redirect("BLogin.aspx");
        }
    }
}