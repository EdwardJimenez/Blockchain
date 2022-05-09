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
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                CargarRolUser();
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string Email = txtEstudiante.Text;
            string Password = txtApellidos.Text;
            string UsuarioNetvalle = "a";
            string RolUser = "U";
            string Title = "j";
            string d = "d";
            if (Email != string.Empty && Password != string.Empty && UsuarioNetvalle != string.Empty && RolUser != string.Empty && Title != string.Empty )
            {
                try
                {

                    //using ( cliente=new SWADBlockchainService.SWADNETBlockchainClient())
                    //{
                    //    EBUser eBUser = new EBUser(Email,Password,UsuarioNetvalle,RolUser,Title);
                    //    cliente.Insertar_BUser_I_idUser_email(eBUser);

                    //}
                    string Id_User = swLNBlockchainClient.SiguienteID_O_NombreTablaSinElCaracterI("BUser");
                    swLNBlockchainClient.Insertar_BUser_I_idUser_email(Id_User, Email, Password, UsuarioNetvalle, ddlPlaza.SelectedValue, Title);
                    //RegistrarProgramaRequerimiento();
                   
                    lblMensaje.Text = "Registro de Usuario Exitoso!!!";
                    
                }
                catch (Exception)
                {

                    lblMensaje.Text = "Registro de Usuario No Insertado";
                }
                    
                
                
            }
            
        }
        private void CargarRolUser()
        {
            ddlPlaza.Items.Clear();

            List<EBRoluser> lstPlaza = new List<EBRoluser>();
            lstPlaza = swLNBlockchainClient.Obtener_RolUser_O().ToList();
            ddlPlaza.DataSource = lstPlaza;
            ddlPlaza.DataTextField = "name";
            ddlPlaza.DataValueField = "IdrolUser";
            ddlPlaza.DataBind();
            ddlPlaza.SelectedIndex = 0;
        }
    }
}