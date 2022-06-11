using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.SWLNBlockchainService;

namespace WABlockchain.WebForm
{
    public partial class BLogin : System.Web.UI.Page
    {
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        static int a = 1; //Son variables predeterminadas para igualar el rol obtenido y así asignarle uno
        static int b = 2;
        static int c = 3;
        private void CargarRolUser()
        {
            
            EBUser Rol = new EBUser();
            Rol = swLNBlockchainClient.Obtener_RolUser_O_Search(txtNombre.Text, txtPassword.Text);

            this.LRol.Text = Rol.IdRolUser;
            if(txtNombre.Text=="" || txtPassword.Text=="")
            {
                //Son labels que cumplirán la función de validar los campos
                LC1.Text = "Falta llenarse un campo";
                LRol.Text = "Falta llenarse un campo";
            }
            else
            {
                if (a == Convert.ToInt32(this.LRol.Text))
                {
                    z0.Text = "ReadOnly";
                    Session["IdRol"] = "1";
                }
                else if (b == Convert.ToInt32(this.LRol.Text))
                {
                    z0.Text = "Admin";
                    Session["IdRol"] = "2";
                    Response.Redirect("BMenuPrincipal.aspx");
                }
                else if (c == Convert.ToInt32(this.LRol.Text))
                {
                    z0.Text = "Secretaria";
                    Session["IdRol"] = "3";
                    Response.Redirect("BMenuPrincipal.aspx");
                }
                else
                {
                    z0.Text = "VRA";
                    Session["IdRol"] = "4";
                    Response.Redirect("BMenuPrincipal.aspx");
                }
            }
            
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            CargarRolUser();            
        }
    }
}