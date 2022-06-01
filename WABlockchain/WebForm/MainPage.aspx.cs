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
        EBTittle eBTittle = new EBTittle();

        protected void Page_Load(object sender, EventArgs e)
        {
            ListarTituladosGeneral();
            //CargarFacultad();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            List<EBTittle> lstTitle = new List<EBTittle>();
            EBTittle eBTittle = new EBTittle();
            eBTittle = swLNBlockchainClient.BUser_O_Search(TextBox1.Text);
            lstTitle.Add(eBTittle);
            grvTitulados.DataSource = lstTitle;
            grvTitulados.DataBind();
            grvTitulados.SelectedIndex = 0;
            TextBox1.Text = "";
        }

        private void ListarTituladosGeneral()
        {
            List<EBTittle> lstTitle = new List<EBTittle>();
            lstTitle = swLNBlockchainClient.Obtener_Title_O_ListGraduates().ToList();
            grvTitulados.DataSource = lstTitle;
            grvTitulados.DataBind();
            grvTitulados.SelectedIndex = 0;
        }

        protected void btnrecargar_Click(object sender, EventArgs e)
        {
            ListarTituladosGeneral();
            TextBox1.Text = "";
        }
        //private void CargarFacultad()
        //{
        //    D1.Items.Clear();

        //    List<EBTittle> lstT = new List<EBTittle>();
        //    lstT = swLNBlockchainClient.BTittle_O_Faculty(D1.Text).ToList();
        //    D1.DataSource = lstT;
        //    D1.DataTextField = "faculty";            
        //    D1.DataBind();
        //    D1.SelectedIndex = 0;
        //}
    }
}