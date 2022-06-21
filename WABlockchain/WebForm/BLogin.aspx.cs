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
        static int only = 1; //Son variables predeterminadas para igualar el rol obtenido y así asignarle uno
        static int admin = 2;
        static int secretaria = 3;
        static int vra = 4;
        private void CargarRolUser()
        {
            lblError.Visible = false;
            EBUser Rol = new EBUser();
            Rol = swLNBlockchainClient.Obtener_RolUser_O_Search(txtNombre.Text, txtPassword.Text);

            this.LRol.Text = Rol.IdRolUser;
            if(txtNombre.Text=="" && txtPassword.Text=="")
            {
                lblError.Visible = false;
            }
            else
            {
                int rolUser = this.LRol.Text != "" ? Convert.ToInt32(this.LRol.Text) : 0;
                if (only == rolUser)
                {
                   
                    Session["Rol"] = "ReadOnly";
                    Response.Redirect("BMenuPrincipal.aspx");
                }
                else if (admin == rolUser)
                {
                    
                    Session["Rol"] = "Admin";
                    Response.Redirect("BMenuPrincipal.aspx");
                }
                else if (secretaria == rolUser)
                {
                    
                    Session["Rol"] = "Secretaria";
                    Response.Redirect("BMenuPrincipal.aspx");
                }
                else if (vra == rolUser)
                {
                    
                    Session["Rol"] = "VRA";
                    Response.Redirect("BMenuPrincipal.aspx");
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Credenciales Incorrecto";
                }
                    
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            
            CargarRolUser();            
        }
    }
}