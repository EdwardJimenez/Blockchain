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
    public partial class BEstado7 : System.Web.UI.Page
    {
        /// <summary>
        /// A esta interfaz solo ingresa el VRA, que confirma la llegada de los titulos a su sede.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Rol"] != null)
                {
                    if (Session["Rol"].ToString() == "VRA")
                    {
                        cargarTitulos();
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
        /// <summary>
        /// Clases instanciadas y atributos.
        /// </summary>
        private static Helper _helper = new Helper();
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        private static int s;

        /// <summary>
        /// Metodo que carga o lista los titulos con el estado 6.
        /// </summary>
        private void cargarTitulos()
        {
            List<EBTittle> lstTitle = new List<EBTittle>();
            lstTitle = swLNBlockchainClient.BTittle_O_State6().ToList();
            grvTitulos.DataSource = lstTitle;
            grvTitulos.DataBind();
            grvTitulos.SelectedIndex = 0;

        }
        /// <summary>
        /// Selecciona el titulo del gridView y cambia a estado 7.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Actualizar_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            int s = int.Parse(grvTitulos.Rows[id].Cells[0].Text);

            swLNBlockchainClient.BTittle_update_statusTittle_7(s.ToString());
            cargarTitulos();
        }
    }
}