using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.SWLNBlockchain;

namespace WABlockchain.WebForm
{
    public partial class ILogin : System.Web.UI.Page
    {
        static string Email = "";
        static string Password = "";

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            //Realizar la funcionalidad para autenticar al usuario
            SWLNBlockchainClient sWLNBlockchain = new SWLNBlockchainClient();
            string Email = txtNombre.Text;
            string Password = txtPassword.Text;
            //ENPersona datosPersona = new ENPersona();
            //if (Email != string.Empty && Password != string.Empty)
            //{
            //    try
            //    {
            //        //string Id_UsuariosLocales = swLNIntercambioClient.SiguienteID_O_NombreTablaSinElCaracterI("Programa");
            //        //swLNIntercambioClient.Insertar_IPrograma_I(Id_Programa, txtPrograma.Text, ddlPlaza.SelectedValue, DateTime.Parse(txtInicio.Text), DateTime.Parse(txtFin.Text));
            //        using (SWADBlockchainService.SWADNETBlockchainClient cliente = new SWADBlockchainService.SWADNETBlockchainClient())
            //        {
            //            ENPerson eBUser = new EBUser(Email, Password, UsuarioNetvalle, RolUser, Title);
            //            cliente.Insertar_BUser_I_idUser_email(eBUser);

            //        }

            //        //RegistrarProgramaRequerimiento();
            //        lblMensaje.Text = "Usuario Conectado Exitoso!!!";

            //    }
            //    catch (Exception)
            //    {

            //        lblMensaje.Text = "Registro de Usuario No Insertado";
            //    }
            //}
            
        }
    }
}