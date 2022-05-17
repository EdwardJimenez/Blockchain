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
            /*int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            int s = int.Parse(grvTitulos.Rows[id].Cells[0].Text);
            swLNBlockchainClient.Actualizar_ITitle_statusTitle(s.ToString());
            cargarTitulos();*/
        }
    }
}