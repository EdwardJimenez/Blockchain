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
            if (!IsPostBack)
            {
                if (Session["Rol"] == null)
                {
                    Session.Remove("Rol");
                    Response.Redirect("BLogin.aspx");
                }
                else
                {
                    string rol = Session["Rol"].ToString();
                    switch (rol)
                    {
                        case "ReadOnly": 
                            LBLNombreUsuario.InnerHtml = "Usuario Lector".ToString();
                            break;
                        case "Admin":
                            LBLNombreUsuario.InnerHtml = "Administrador".ToString();
                            break;
                        case "Secretaria":
                            LBLNombreUsuario.InnerHtml = "Secretaria".ToString();
                            break;
                        case "VRA":
                            LBLNombreUsuario.InnerHtml = "ViceRectorado Academico".ToString();
                            break;
                    }
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