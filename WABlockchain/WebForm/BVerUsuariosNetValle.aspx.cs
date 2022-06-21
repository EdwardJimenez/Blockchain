using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.SWLNBlockchainService;

namespace WABlockchain.WebForm
{
    public partial class BVerUsuariosNetValle : System.Web.UI.Page
    {
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Rol"] != null)
                {
                    if (Session["Rol"].ToString() == "Admin")
                    {
                        CargarRequerimientos();
                    }
                    else
                    {
                        Response.Redirect("BMenuPrincipal.aspx");
                    }
                }
                else
                {
                    Response.Redirect("BLogin.aspx");
                }
            }
        }
        private void CargarRequerimientos()
        {
            List<IUserCareerCompleja> lstProgramaRequerimientoCompleja = new List<IUserCareerCompleja>();
            lstProgramaRequerimientoCompleja = swLNBlockchainClient.U_Obtener_UserCareerComplejas_O_Person().ToList();
            grvUsersNetvalle.DataSource = lstProgramaRequerimientoCompleja;
            grvUsersNetvalle.DataBind();
        }
        protected void btn1_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            int s = int.Parse(grvUsersNetvalle.Rows[id].Cells[0].Text);
            Session["idUsuario"] = s;
            Response.Redirect("BRegistroUsuarioNuevo.aspx");
        }
    }
}