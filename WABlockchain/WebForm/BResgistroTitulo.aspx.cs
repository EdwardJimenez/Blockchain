using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.SWLNBlockchainService;
using WABlockchain.Class;
using WABlockchain.Template.Util;
using System.Net;

namespace WABlockchain.WebForm
{
    public partial class BResgistroTitulo : System.Web.UI.Page
    {
        /// <summary>
        /// Clases instanciadas y atributos.
        /// </summary>
        private static Helper _helper = new Helper();
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        GenerarPDF generarPDF = new GenerarPDF();
        private static int s;

        /// <summary>
        /// A esta interfaz solo ingresa la secretaria, para luego registrar un titulo
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
                        deshabilitarTextbox();
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
        /// Metodo que oculta los campos de datos id y su label.
        /// </summary>
        private void deshabilitarTextbox()
        {
            this.txtId.Visible = false;
            this.Label3.Visible = false;
        }
        /// <summary>
        /// Metodo para cargar o listar los titulos una vez registrado y se establecen en estado 1.
        /// </summary>
        private void cargarTitulos()
        {
            List<EBTittle> lstTitle = new List<EBTittle>();
            lstTitle = swLNBlockchainClient.Obtener_Title_1().ToList();
            grvTitulos.DataSource = lstTitle;
            grvTitulos.DataBind();
            grvTitulos.SelectedIndex = 0;
        }
        /// <summary>
        /// Metodo para limpiar los campos de entradas de datos.
        /// </summary>
        private void LimpiarTitulos()
        {
            txtFacultad.Text = string.Empty;
            txtCarrera.Text = string.Empty;
            txtNombre.Text = string.Empty;

        }

        /// <summary>
        /// Registra un titulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string Facultad = txtFacultad.Text;
            string Carrera = txtCarrera.Text;
            string NombreCompleto = txtNombre.Text;

            try
            {
                List<EBTittle> lstTitle = new List<EBTittle>();
                lstTitle = swLNBlockchainClient.Search_BTitle(NombreCompleto, Carrera, Facultad).ToList();

                if (lstTitle.Count() > 0)
                {
                    lblmensaje.Text = "Ya existe un registro";
                    lblmensaje.Visible = true;
                }
                else
                {
                    if (Facultad.Equals("") || Carrera.Equals("") || NombreCompleto.Equals(""))
                    {
                        lblmensaje.Text = "Lo campos no deben estar vacíos!!!";
                    }
                    else
                    {
                        string Id_Titulo = swLNBlockchainClient.SiguienteID_O_NombreTablaSinElCaracterI("Tittle");
                        swLNBlockchainClient.Insertar_BTitle(Id_Titulo, Facultad.ToUpper(), Carrera.ToUpper(), "1", NombreCompleto.ToUpper());    
                        cargarTitulos();
                        lblmensaje.Text = "Registro de Título Exitoso!!!";
                        LimpiarTitulos();
                    }
                }
            }
            catch (Exception)
            {
                lblmensaje.Text = "Registro de Título No Insertado !!!";
            }
        }
        /// <summary>
        /// Elimina un titulo registrado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            int s = int.Parse(grvTitulos.Rows[id].Cells[0].Text);
            swLNBlockchainClient.Eliminar_ITitle_statusTitle(s.ToString());
            cargarTitulos();
            lblmensaje.Text = "Registro Eliminado con Éxito !!!";
        }
        /// <summary>
        /// Actualiza un titulo registrado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string Facultad = txtFacultad.Text;
            string Carrera = txtCarrera.Text;
            string NombreCompleto = txtNombre.Text;
            try
            {
                if (Facultad.Equals("") || Carrera.Equals("") || NombreCompleto.Equals(""))
                {
                    lblmensaje.Text = "Lo campos no deben estar vacíos!!!";
                }
                else
                {
                    swLNBlockchainClient.Actualizar_ITitle(txtId.Text, Carrera.ToUpper(), Facultad.ToUpper(), NombreCompleto.ToUpper());
                    cargarTitulos();
                    LimpiarTitulos();
                }
            }
            catch (Exception)
            {
                lblmensaje.Text = "Error al Actualizar!!!";
            }
        }
        /// <summary>
        /// Selecciona un titulo y carga sus datos en los campos de entrada para ser actualizado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Actualizar_Click(object sender, EventArgs e)
        {
                int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;

                txtNombre.Text = grvTitulos.Rows[id].Cells[1].Text;
                txtFacultad.Text = grvTitulos.Rows[id].Cells[2].Text;
                txtCarrera.Text = grvTitulos.Rows[id].Cells[3].Text;
                txtId.Text = grvTitulos.Rows[id].Cells[0].Text;
        }
        /// <summary>
        /// Genera un archivo PDF y lo visualiza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnPDF_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
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
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Metodo para generar un codigo alfanumerico de 10 digitos.
        /// </summary>
        /// <returns>codigo</returns>
        public string GeneratePassword()
        {
            Random ran = new Random();
            string characteres = @"ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int longth = characteres.Length;
            char letter;
            int digit = 10;
            string dom = string.Empty;
            for (int i = 0; i < digit; i++)
            {
                letter = characteres[ran.Next(longth)];
                dom += letter.ToString();
            }
            return dom;
        }
    }
}