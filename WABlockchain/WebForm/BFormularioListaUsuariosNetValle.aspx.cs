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
            if(!IsPostBack)
            {
                if (Session["Rol"] != null)
                {
                    if (Session["Rol"].ToString() == "Secretaria")
                    {
                        CargarRequerimientos();
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


        protected void grvUsersNetvalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Errorsito jaja By pedro 
        }

        /// <summary>
        /// Carga a los usuarios y a su carrera , facultad respectiva
        /// </summary>
        private void CargarRequerimientos()
        {
            List<IUserCareerCompleja> lstProgramaRequerimientoCompleja = new List<IUserCareerCompleja>();
            lstProgramaRequerimientoCompleja = swLNBlockchainClient.U_Obtener_UserCareerComplejas_O_Est().ToList();
            grvUsersNetvalle.DataSource = lstProgramaRequerimientoCompleja;
            grvUsersNetvalle.DataBind();
        }
        /// <summary>
        /// Manda el ID de la persona asignada y lo envia al apartado de Registrar titulos por la secretaria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn1_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            int s = int.Parse(grvUsersNetvalle.Rows[id].Cells[0].Text);
            Session["idTitulo"] = s;
            Response.Redirect("BResgistroTitulo.aspx");
        }
        /// <summary>
        /// Es un buscador por medio del nombre de un estudiante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {
            grvUsersNetvalle.DataSource = null;
            List<IUserCareerCompleja> lstEISolicitud = new List<IUserCareerCompleja>();
            lstEISolicitud = swLNBlockchainClient.U_Obtener_UserCareerComplejas_O_Est_Bus(txtNombre.Text).ToList();
            grvUsersNetvalle.DataSource = lstEISolicitud;
            grvUsersNetvalle.DataBind();
            txtNombre.Text = string.Empty;

        }
    }
}