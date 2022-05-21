using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.SWLNBlockchainService;

namespace WABlockchain.WebForm
{
    public partial class ILogin : System.Web.UI.Page
    {
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        private void CargarRolUser()
        {
            int a = 1;
            int b = 2;
            int c = 3;
            EBUser Rol = new EBUser();
            Rol = swLNBlockchainClient.Obtener_RolUser_O_Search(txtNombre.Text, txtPassword.Text);

            z.Text = Rol.IdRolUser;
            if (a== Convert.ToInt32(z.Text))
            {
                z0.Text = "ReadOnly";
            }
            else if (b == Convert.ToInt32(z.Text))
            {
                z0.Text = "Admin";
            }else if(c == Convert.ToInt32(z.Text))
            {
                z0.Text = "Secretaria";
            }
            else
            {
                z0.Text = "VRA";
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