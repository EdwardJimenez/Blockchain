using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.SWLNBlockchainService;
using WABlockchain.Class;
using WABlockchain.Template.Util;

namespace WABlockchain.WebForm
{
    public partial class BResgistroTitulo : System.Web.UI.Page
    {
        //SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        private static Helper _helper = new Helper();
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        GenerarPDF generarPDF = new GenerarPDF();
        private static int s;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarTitulos();
                deshabilitarTextbox();
                
                //if (Session["idUsuario"] != null)
                //{
                //    try
                //    {
                //        //Esto lo tengo que borrar , no es aqui ,es en la webforms de Registrar titulos Pedro Conde
                //        IUserCareerCompleja iusercompleja = new IUserCareerCompleja();
                //        int IDUser = Convert.ToInt32(Session["idUsuario"]);
                //        iusercompleja = swLNBlockchainClient.U_Obtener_UserCareerComplejas_O_Est_ID(IDUser)[0];
                //        txtFacultad.Text = iusercompleja.FacultyName.ToString();
                //        txtCarrera.Text = iusercompleja.CareerName.ToString();
                //        txtNombreCompleto.Text = iusercompleja.Fullname.ToString();
                //        txtEmail.Text = iusercompleja.Mail.ToString();
                //        txtCi.Text = iusercompleja.CI.ToString();
                //        txtCIExtra.Text = iusercompleja.ExtCI.ToString();

                //    }
                //    catch (Exception)
                //    {

                //        throw;
                //    }
                //}
            }
        }
        private void deshabilitarTextbox()
        {
            this.txtId.Visible = false;
            this.Label3.Visible = false;
        }
        private void cargarTitulos()
        {
            List<EBTittle> lstTitle = new List<EBTittle>();
            lstTitle = swLNBlockchainClient.Obtener_Title_O().ToList();
            grvTitulos.DataSource = lstTitle;
            grvTitulos.DataBind();
            grvTitulos.SelectedIndex = 0;
        }

       

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string Facultad = txtFacultad.Text;
            string Carrera = txtCarrera.Text;
            string Fullname = txtNombre.Text;



            try
            {
                string Id_Titulo = swLNBlockchainClient.SiguienteID_O_NombreTablaSinElCaracterI("Tittle");
                //string Id_Titulo = swLNBlockchainClient.UltimoID_O_NombreTablaSinElCaracterI("User");
                swLNBlockchainClient.Insertar_BTitle(Id_Titulo, Facultad, Carrera, "1", Fullname);


                cargarTitulos();
                lblmensaje.Text = "Registro de Título Exitoso!!!";
               
            }
            catch (Exception)
            {
                lblmensaje.Text = "Registro de Título No Insertado";
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            int s = int.Parse(grvTitulos.Rows[id].Cells[0].Text);
            swLNBlockchainClient.Eliminar_ITitle_statusTitle(s.ToString());
            cargarTitulos();

        }
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            swLNBlockchainClient.Actualizar_ITitle(txtId.Text, txtCarrera.Text, txtFacultad.Text, txtNombre.Text);
            cargarTitulos();
        }
        protected void Actualizar_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            txtNombre.Text = grvTitulos.Rows[id].Cells[1].Text;
            txtFacultad.Text = grvTitulos.Rows[id].Cells[2].Text;
            txtCarrera.Text = grvTitulos.Rows[id].Cells[3].Text;
            txtId.Text = grvTitulos.Rows[id].Cells[0].Text;
        }

        protected void btnPDF_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            string nombreCompleto = grvTitulos.Rows[id].Cells[1].Text;
            string carrera = grvTitulos.Rows[id].Cells[3].Text;
            generarPDF.GenerarNuevoPDF(nombreCompleto, carrera);
        }
    }
}