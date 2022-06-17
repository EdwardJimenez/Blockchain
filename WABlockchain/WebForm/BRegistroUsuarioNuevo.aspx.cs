using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.SWLNBlockchainService;

namespace WABlockchain.WebForm
{
    public partial class BRegistroUsuarioNuevo : System.Web.UI.Page
    {
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarRolUser();
                if (Session["idUsuario"] != null)
                {
                    try
                    {
                        txtUsuarioNetvalle.Text = "SI";
                        IUserCareerCompleja iusercompleja = new IUserCareerCompleja();
                        int IDUser = Convert.ToInt32(Session["idUsuario"]);
                        iusercompleja = swLNBlockchainClient.U_Obtener_UserCareerComplejas_O_Est_ID(IDUser)[0];
                        txtNombreEstudiante.Text = iusercompleja.Fullname.ToString();
                        txtTelefonos.Text = iusercompleja.Phone.ToString();
                        txtCorreo.Text = iusercompleja.Mail.ToString();
                        txtCi.Text = iusercompleja.CI.ToString();
                        txtCiextra.Text = iusercompleja.ExtCI.ToString();

                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreEstudiante.Text;
            string apellido = txtApellidos.Text;
            string Fullname = nombre + " " + apellido;
            string Email = txtCorreo.Text;
            string Password = txtPassword.Text;
            string Cellphone = txtTelefonos.Text;
            string UsuarioNetvalle = txtUsuarioNetvalle.Text;
            string CIUser = txtCi.Text;
            string descripcion = txtDescripcion.Text;
            string ciExtra = txtCiextra.Text;
            string status = "1";
            try
            {
                string Id_User = swLNBlockchainClient.SiguienteID_O_NombreTablaSinElCaracterI("User");
                swLNBlockchainClient.Insertar_BUser_I(Id_User, Email, Password, status, UsuarioNetvalle, ddlRol.SelectedValue, Fullname, Cellphone, CIUser, descripcion, ciExtra);
                txtNombreEstudiante.Text = "";
                txtApellidos.Text = "";
                txtCorreo.Text = "";
                txtPassword.Text = "";
                txtCorreo.Text = "";
                txtUsuarioNetvalle.Text = "SI";
                txtCi.Text = "";
                txtDescripcion.Text = "";
                txtCiextra.Text = "";
            }
            catch (Exception)
            {
            }
        }
        private void CargarRolUser()
        {
            ddlRol.Items.Clear();

            List<EBRoluser> lstRol = new List<EBRoluser>();
            lstRol = swLNBlockchainClient.Obtener_RolUser_O().ToList();
            ddlRol.DataSource = lstRol;
            ddlRol.DataTextField = "name";
            ddlRol.DataValueField = "IdrolUser";
            ddlRol.DataBind();
            ddlRol.SelectedIndex = 0;
        }
    }
}