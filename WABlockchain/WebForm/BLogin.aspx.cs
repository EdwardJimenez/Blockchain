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
        /// <summary>
        /// Son variables staticas predeterminadas para igualar el rol obtenido y así asignarle uno
        /// </summary>
        static int admin = 1; 
        static int only = 2;
        static int secretaria = 3;
        static int vra = 4;

        /// <summary>
        /// Metodo que obtiene el rol y compara las credenciales
        /// </summary>
        private void CargarRolUser()
        {
            lblError.Visible = false;
            EBUser Rol = new EBUser();
            Rol = swLNBlockchainClient.Obtener_RolUser_O_Search(txtNombre.Text.ToUpper(), txtPassword.Text);

            this.LRol.Text = Rol.IdRolUser;
            if(txtNombre.Text=="" && txtPassword.Text=="")
            {
                lblError.Visible = false;
            }
            else
            {
                //Se almacena en la variable y determina si existe un usuario.
                int rolUser = this.LRol.Text != "" ? Convert.ToInt32(this.LRol.Text) : 0;
                if (admin == rolUser)
                {
                   
                    Session["Rol"] = "Admin";
                    Response.Redirect("BMenuPrincipal.aspx");
                }
                else if (only == rolUser)
                {
                    
                    Session["Rol"] = "ReadOnly";
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
            if (!IsPostBack)
            {
                if (Session["Rol"] != null)
                {
                    Response.Redirect("BMenuPrincipal.aspx");
                }
            }
        }
        /// <summary>
        /// Boton que acciona el metodo que compara si estan correctas las credenciales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCargar_Click(object sender, EventArgs e)
        {
            CargarRolUser();            
        }
    }
}