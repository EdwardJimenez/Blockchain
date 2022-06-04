using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.SWLNBlockchainService;

namespace WABlockchain.WebForm
{
    public partial class BResgistroTitulo : System.Web.UI.Page
    {
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void grvTitulos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}