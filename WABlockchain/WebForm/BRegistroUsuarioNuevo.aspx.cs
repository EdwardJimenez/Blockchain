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
        /// <summary>
        /// A esta pantalla solo ingresa el administrador, se registra los usuarios tanto normales como netvalle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            lblmsg.Visible = false;
            if (!IsPostBack)
            {
                if (Session["Rol"] != null)
                {
                    if (Session["Rol"].ToString() == "Admin")
                    {
                        CargarRolUser();
                        // Agarras el id que fue mandada desde la pagina para ver a los usuarios netvalle
                        // para poder comparar con un metodo y asi comparar sus datos con los "txt" vacios
                        if (Session["idUsuario"] != null)
                        {
                            try
                            {
                                IUserCareerCompleja iusercompleja = new IUserCareerCompleja();
                                int IDUser = Convert.ToInt32(Session["idUsuario"]);
                                iusercompleja = swLNBlockchainClient.U_Obtener_UserCareerComplejas_O_Est_ID(IDUser)[0];
                                txtNombreEstudiante.Text = iusercompleja.Fullname.ToString().ToUpper();
                                txtTelefonos.Text = iusercompleja.Phone.ToString();
                                txtCorreo.Text = iusercompleja.Mail.ToString().ToUpper();
                                txtCi.Text = iusercompleja.CI.ToString().ToUpper();
                                txtCiextra.Text = iusercompleja.ExtCI.ToString().ToUpper();
                                txtSede.Text = iusercompleja.SedeName.ToString().ToUpper();
                            }
                            catch (Exception)
                            {

                                throw;
                            }
                        }
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
        /// Registras a los usuarios normales como los Netvalle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            string sede = txtSede.Text;
            try
            {
                string Id_User = swLNBlockchainClient.SiguienteID_O_NombreTablaSinElCaracterI("User");
                swLNBlockchainClient.Insertar_BUser_I(Id_User, Email.ToUpper(), Password, status, UsuarioNetvalle.ToUpper(), ddlRol.SelectedValue.ToUpper(), Fullname.ToUpper(), Cellphone, CIUser.ToUpper(), descripcion.ToUpper(), ciExtra.ToUpper(), sede.ToUpper());
                lblmsg.Visible = true;
            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// Aqui se carga los roles que puede tener un usuario para registrarlo
        /// </summary>// 
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