using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.SWLNBlockchainService;
using WABlockchain.Class;


namespace WABlockchain.WebForm
{
    public partial class BFormularioListaUsuariosNetValle : System.Web.UI.Page
    {
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarRequerimientos();
        }

        private void CargarRequerimientos()
        {
            List<IUserCareerCompleja> lstProgramaRequerimientoCompleja = new List<IUserCareerCompleja>();
            lstProgramaRequerimientoCompleja = swLNBlockchainClient.U_Obtener_UserCareerComplejas_O_Est().ToList();
            grvUsersNetvalle.DataSource = lstProgramaRequerimientoCompleja;
            grvUsersNetvalle.DataBind();
        }
        protected void grvUsersNetvalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Errorsito jaja By pedro 
        }
        
        protected void btn1_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            int s = int.Parse(grvUsersNetvalle.Rows[id].Cells[0].Text);
            Session["idUsuario"] = s;
            Response.Redirect("BFormularioRegistrosUsuariosLocales.aspx");
        }

        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {
            grvUsersNetvalle.DataSource = null;
            List<IUserCareerCompleja> lstEISolicitud = new List<IUserCareerCompleja>();
            lstEISolicitud = swLNBlockchainClient.U_Obtener_UserCareerComplejas_O_Est_Bus(txtNombre.Text).ToList();

            grvUsersNetvalle.DataSource = lstEISolicitud;
            grvUsersNetvalle.DataBind();
            txtNombre.Text = string.Empty;
        }
    }
}