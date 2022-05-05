using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.SWADBlockchainService;

namespace WABlockchain.WebForm
{
    public partial class BFormularioRegistrosUsuariosLocales : System.Web.UI.Page
    {
        //SWLNIntercambioClient swLNIntercambioClient = new SWLNIntercambioClient();
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string Email = txtEstudiante.Text;
            string Password = txtApellidos.Text;
            string UsuarioNetvalle = "a";
            string RolUser = "U";
            string Title = "j";
            if (Email != string.Empty && Password != string.Empty && UsuarioNetvalle != string.Empty && RolUser != string.Empty && Title != string.Empty )
            {
                try
                {
                    //string Id_UsuariosLocales = swLNIntercambioClient.SiguienteID_O_NombreTablaSinElCaracterI("Programa");
                    //swLNIntercambioClient.Insertar_IPrograma_I(Id_Programa, txtPrograma.Text, ddlPlaza.SelectedValue, DateTime.Parse(txtInicio.Text), DateTime.Parse(txtFin.Text));
                    using (SWADBlockchainService.SWADNETBlockchainClient cliente=new SWADBlockchainService.SWADNETBlockchainClient())
                    {
                        EBUser eBUser = new EBUser(Email,Password,UsuarioNetvalle,RolUser,Title);
                        cliente.Insertar_BUser_I_idUser_email(eBUser);
                        
                    }

                        //RegistrarProgramaRequerimiento();
                        lblMensaje.Text = "Registro de Usuario Exitoso!!!";
                    
                }
                catch (Exception)
                {

                    lblMensaje.Text = "Registro de Usuario No Insertado";
                }
                    
                
                
            }
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Notificacion()", true);
        }
    }
}