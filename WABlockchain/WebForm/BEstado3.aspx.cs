using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.SWLNBlockchainService;
using WABlockchain.Template.Util;

namespace WABlockchain.WebForm
{
    public partial class BEstado3 : System.Web.UI.Page
    {
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        GenerarPDF generarPDF = new GenerarPDF();

        /// <summary>
        /// A esta interfaz solo ingresa la secretaria, para luego realizar la impresion de los titulos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Rol"] != null)
                {
                    if (Session["Rol"].ToString() == "Secretaria")
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
        /// Selecciona el titulo y cambia su estado a estado 3.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
                int s = int.Parse(grvTitulos.Rows[id].Cells[0].Text);
                string nombreCompleto = grvTitulos.Rows[id].Cells[1].Text;
                string carrera = grvTitulos.Rows[id].Cells[3].Text;
                string mostrar = generarPDF.GenerarNuevoPDF(nombreCompleto, carrera);

                WebClient web = new WebClient();
                Byte[] FileBuffer = web.DownloadData(mostrar);

                if (FileBuffer != null)
                {
                    Response.ContentType = "application/pdf";
                    Response.AddHeader("content-length", FileBuffer.Length.ToString());
                    Response.BinaryWrite(FileBuffer);
                }

                swLNBlockchainClient.BTittle_update_statusTittle_3(s.ToString());
                cargarTitulos();
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Metodo que carga o lista los titulos con el estado 2.
        /// </summary>
        private void cargarTitulos()
        {
            List<EBTittle> lstTitle = new List<EBTittle>();
            lstTitle = swLNBlockchainClient.BTittle_O_State2().ToList();
            grvTitulos.DataSource = lstTitle;
            grvTitulos.DataBind();
            grvTitulos.SelectedIndex = 0;

        }
    }
}