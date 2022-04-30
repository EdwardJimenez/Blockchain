using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WABlockchain.WebForm
{
    public partial class FormularioRegistroUsuariosLocales : System.Web.UI.Page
    {
        SWLNItercambioClient swLNIntercambioCliente = new SWLNItercambioClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btnRegistrar_Click(Object sender, EventArgs e)
        {
            if (codigoCarta.Text)
            {

            }
        }


    }
}