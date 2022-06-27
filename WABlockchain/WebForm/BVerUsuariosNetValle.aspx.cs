using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.SWLNBlockchainService;

namespace WABlockchain.WebForm
{
    public partial class BVerUsuariosNetValle : System.Web.UI.Page
    {
        /// <summary>
        ///  Aqui se visualiza a los usuarios NetValle para luego ser enviados a la pagina de registro de los usuarios a la Base de datos
        /// </summary>
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Rol"] != null)
                {
                    if (Session["Rol"].ToString() == "Admin")
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
        /// <summary>
        /// Se carga el grid view para poder visualizar a los usuarios al momento de ingresar a la pagina
        /// </summary>
        private void CargarRequerimientos()
        {
            List<IUserCareerCompleja> lstProgramaRequerimientoCompleja = new List<IUserCareerCompleja>();
            lstProgramaRequerimientoCompleja = swLNBlockchainClient.U_Obtener_UserCareerComplejas_O_Person().ToList();
            grvUsersNetvalle.DataSource = lstProgramaRequerimientoCompleja;
            grvUsersNetvalle.DataBind();
        }
        /// <summary>
        /// Aqui se agarra el ID de un usuario para poder mandar ese ID a la pantalla de registro de usuarios a la Base de datos
        /// para poder ser registrado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn1_Click(object sender, EventArgs e)
        {
            int id = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            int s = int.Parse(grvUsersNetvalle.Rows[id].Cells[0].Text);
            Session["idUsuario"] = s;
            Response.Redirect("BRegistroUsuarioNuevo.aspx");
        }
    }
}