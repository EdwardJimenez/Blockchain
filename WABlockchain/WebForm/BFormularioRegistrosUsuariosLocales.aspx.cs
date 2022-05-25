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
    public partial class BFormularioRegistrosUsuariosLocales : System.Web.UI.Page
    {
        
        private static Helper _helper = new Helper();
 
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        private string _Id_Requerimiento = string.Empty;
        private string _Id_User = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarRolUser();
                if (Session["idUsuario"] !=null)
                {
                    try
                    {
                        //Esto lo tengo que borrar , no es aqui ,es en la webforms de Registrar titulos Pedro Conde
                        IUserCareerCompleja iusercompleja = new IUserCareerCompleja();
                        int IDUser = Convert.ToInt32(Session["idUsuario"]);
                        iusercompleja = swLNBlockchainClient.U_Obtener_UserCareerComplejas_O_Est_ID(IDUser)[0];
                        txtApellido.Text = iusercompleja.CareerName.ToString();
                        txtNombre.Text= iusercompleja.Fullname.ToString();
                        txtCellphone.Text = iusercompleja.FacultyName.ToString();
                        txtCi.Text = iusercompleja.SedeName.ToString();
                        
                        
                        

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
            
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string Fullname = nombre + " " + apellido;
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;
            string Cellphone = txtCellphone.Text;
            string UsuarioNetvalle = txtUserNetvalle.Text;
            string CIUser = txtCi.Text;
            string descripcion = txtDescripcion.Text;
            string ciExtra = txtCIExtra.Text;
            string status = "1";
            try
            {
                string Id_User = swLNBlockchainClient.SiguienteID_O_NombreTablaSinElCaracterI("User");
                swLNBlockchainClient.Insertar_BUser_I(Id_User, Email, Password, status, UsuarioNetvalle, ddlRolUser.SelectedValue, Fullname, Cellphone, CIUser, descripcion, ciExtra);
                //RegistrarProgramaRequerimiento();

                lblMensaje.Text = "Registro de Usuario Exitoso!!!";

            }
            catch (Exception)
            {

                lblMensaje.Text = "Registro de Usuario No Insertado";
            }
        }
        private void CargarRolUser()
        {
            ddlRolUser.Items.Clear();

            List<EBRoluser> lstRol = new List<EBRoluser>();
            lstRol = swLNBlockchainClient.Obtener_RolUser_O().ToList();
            ddlRolUser.DataSource = lstRol;
            ddlRolUser.DataTextField = "name";
            ddlRolUser.DataValueField = "IdrolUser";
            ddlRolUser.DataBind();
            ddlRolUser.SelectedIndex = 0;
        }
    }
}