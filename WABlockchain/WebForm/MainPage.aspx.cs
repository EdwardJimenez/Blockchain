using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.SWLNBlockchainService;

namespace WABlockchain.WebForm
{
    public partial class MainPage : System.Web.UI.Page
    {

        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    ListarTituladosGeneral();
            //}
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            {
                ListarTituladosGeneral();
            }
        }

        private void ListarTituladosGeneral()
        {
            List<EBTittle> lstTitle = new List<EBTittle>();
            lstTitle = swLNBlockchainClient.Obtener_Title_O_ListGraduates().ToList();
            grvTitulados.DataSource = lstTitle;
            grvTitulados.DataBind();
            grvTitulados.SelectedIndex = 0;
        }
    }
}