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
                    //btn_Users.Visibility = Visibility.Collapsed;
                    //btnTransacciones.Visibility = Visibility.Collapsed;
                    break;
                case "Secretaria":
                    //btn_Users.Visibility = Visibility.Collapsed;
                    //btnGanado.Visibility = Visibility.Collapsed;
                    //btnTransacciones.Visibility = Visibility.Collapsed;
                    break;
                case "VRA":
                    //btn_Users.Visibility = Visibility.Collapsed;
                    //btnGanado.Visibility = Visibility.Collapsed;
                    //btnTransacciones.Visibility = Visibility.Collapsed;
                    break;
            }
        }

        //protected void btnBuscar_Click(object sender, EventArgs e)
        //{
        //    EBTittle tittle = new EBTittle();

        //    GridView1.DataSource = null;
        //    GridView1.DataBind();
        //    try
        //    {
        //        string nombreEst;
        //        if (txtSegundoApellido.Text != "")
        //        {
        //            nombreEst = (txtNombrePersona.Text).Trim() + " " + (txtPrimerApellido.Text).Trim() + " " + (txtSegundoApellido.Text).Trim();
        //        }
        //        else
        //        {
        //            nombreEst = (txtNombrePersona.Text).Trim() + " " + (txtPrimerApellido.Text).Trim();
        //        }
        //        List<EBTittle> lstTitle = new List<EBTittle>();
        //        lstTitle = swLNBlockchainClient.Search_BTitle(nombreEst, txtCarrera.Text, txtFacultad.Text).ToList();
        //        if (lstTitle.Count() == 0)
        //        {
        //            lblMensaje.Text = "No se encontro el titulo verifica tus datos";
        //        }
        //        else
        //        {
        //            grvTitulos.DataSource = lstTitle;
        //            grvTitulos.DataBind();
        //            grvTitulos.SelectedIndex = 0;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        lblMensaje.Text = "No se encontro el titulo verifica tus datos" + ex.Message;
        //    }
        //}

        protected void btnBuscar_Click1(object sender, EventArgs e)
        {
            EBTittle tittle = new EBTittle();
            string faculty = txtBuscador.Text;
            GridView1.DataSource = null;
            GridView1.DataBind();
            //.SelectedIndex = 0;
            //GridView1.Rows[id].Cells[0];

            try
            {
                List<EBTittle> lstTitle = new List<EBTittle>();
                //int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
                lstTitle = swLNBlockchainClient.Search_BTitle_Faculty_Carrer_Date(faculty).ToList();
                if (lstTitle.Count()==0)
                {
                    lblmensaje.Text = "No se encontro el título";
                }
                else
                {
                    GridView1.DataSource = lstTitle;
                    GridView1.DataBind();
                    GridView1.SelectedIndex = 0;
                    //GridView1.Rows[id].Cells[0].Visible=false;
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