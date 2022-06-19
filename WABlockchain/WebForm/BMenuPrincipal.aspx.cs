using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WABlockchain.WebForm
{
    public partial class BMenuPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                if (Session["Rol"] != null)
                {
                    string Rol = Session["Rol"].ToString();
                    switch (Rol)
                    {
                        case "ReadOnly":
                            btnRegistrarUsuario.Visible = false;
                            btnRegistrarTitulo.Visible = false;
                            break;
                        case "Secretaria":
                            btnRegistrarUsuario.Visible = false;
                            btnRegistrarTitulo.Visible = true;
                            break;
                        case "Admin":
                            btnRegistrarUsuario.Visible = true;
                            btnRegistrarTitulo.Visible = false;
                            break;
                        case "VRA":
                            //btn_Users.Visibility = Visibility.Collapsed;
                            //btnGanado.Visibility = Visibility.Collapsed;
                            //btnTransacciones.Visibility = Visibility.Collapsed;
                            break;
                    }
                }
                else
                {
                    Response.Redirect("BLogin.aspx");
                }
            }
        }

        protected void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("BRegistroUsuarioNuevo.aspx");
        }

        protected void btnRegistrarTitulo_Click(object sender, EventArgs e)
        {
            Response.Redirect("BResgistroTitulo.aspx");
        }
    }
}