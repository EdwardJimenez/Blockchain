using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.Class;
using WABlockchain.SWLNBlockchainService;


namespace WABlockchain.WebForm
{
    public partial class BMenuPrincipal : System.Web.UI.Page
    {
        private static Helper _helper = new Helper();
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            switch (Session.SessionID)
            {
                case "1":
                    break;
                case "ReadOnly":
                    break;
                case "Secretaria":
                    break;
                case "VRA":
                    break;
            }
        }

        protected void btnBuscar_Click1(object sender, EventArgs e)
        {
            EBTittle tittle = new EBTittle();
            string faculty = txtBuscador.Text;

            GridView1.DataSource = null;
            GridView1.DataBind();

            try
            {
                List<EBTittle> lstTitle = new List<EBTittle>();

                lstTitle = swLNBlockchainClient.Search_BTitle_Faculty_Carrer_Date(faculty).ToList();
                if (lstTitle.Count() == 0)
                {
                    lblmensaje.Text = "No se encontro el título";
                }
                else
                {
                    GridView1.DataSource = lstTitle;
                    GridView1.DataBind();
                    GridView1.SelectedIndex = 0;
                    lblmensaje.Text = "Título encontrado";
                }
            }
            catch (Exception ex)
            {

                lblmensaje.Text = ex.Message;
            }
        }




    }
}