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
    public partial class BEstado5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarTitulos();
                deshabilitarTextbox();
            }
        }
        private static Helper _helper = new Helper();
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        private static int s;
        private void deshabilitarTextbox()
        {
            this.txtEmail.Visible = false;
            this.txtPassword.Visible = false;
            this.txtCi.Visible = false;
            this.txtDescripcion.Visible = false;
            this.txtCIExtra.Visible = false;
        }
        private void cargarTitulos()
        {
            List<EBTittle> lstTitle = new List<EBTittle>();
            lstTitle = swLNBlockchainClient.BTittle_O_State6().ToList();
            grvTitulos.DataSource = lstTitle;
            grvTitulos.DataBind();
            grvTitulos.SelectedIndex = 0;
        }
        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            string Facultad = txtFacultad.Text;
            string Carrera = txtCarrera.Text;
            string Fullname = txtNombreCompleto.Text;
            try
            {
                string Id_Titulo = swLNBlockchainClient.SiguienteID_O_NombreTablaSinElCaracterI("Tittle");
                //string Id_Titulo = swLNBlockchainClient.UltimoID_O_NombreTablaSinElCaracterI("User");
               // swLNBlockchainClient.Insertar_BTitle(Id_Titulo, Facultad, Carrera, "1", Fullname);


                cargarTitulos();
                lblMensaje.Text = "Registro de Título Exitoso!!!";
            }
            catch (Exception)
            {
                lblMensaje.Text = "Registro de Título No Insertado";
            }
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            int s = int.Parse(grvTitulos.Rows[id].Cells[0].Text);
           // swLNBlockchainClient.Eliminar_ITitle_statusTitle(s.ToString());
            cargarTitulos();

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            swLNBlockchainClient.BTittle_update_statusTittle_7(((GridViewRow)(sender as Control).NamingContainer).RowIndex.ToString());
            cargarTitulos();
        }

        protected void Actualizar_Click(object sender, EventArgs e)
        {
            swLNBlockchainClient.BTittle_update_statusTittle_7("59");
            cargarTitulos();
            /*
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            txtNombreCompleto.Text = grvTitulos.Rows[id].Cells[1].Text;
            txtFacultad.Text = grvTitulos.Rows[id].Cells[2].Text;
            txtCarrera.Text = grvTitulos.Rows[id].Cells[3].Text;
            txtEmail.Text = grvTitulos.Rows[id].Cells[0].Text;*/
        }
    }
}