using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WABlockchain.Class;
using WABlockchain.SWLNBlockchainService;
using System.Globalization;

namespace WABlockchain.WebForm
{
    public partial class BMenuPrincipal : System.Web.UI.Page
    {
        private static Helper _helper = new Helper();
        SWLNBlockchainClient swLNBlockchainClient = new SWLNBlockchainClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (Session.SessionID)
            {
                case "1":
                    break;
                case "ReadOnly":
                    //btn_Users.Visibility = Visibility.Collapsed;
                    //btnTransacciones.Visibility = Visibility.Collapsed;
                    break;
                case "Secretaria":
                    //btn_Users.Visibility = Visibility.Collapsed;
                    //btnGanado.Visibility = Visibility.Collapsed;
                    //btnTransacciones.Visibility = Visibility.Collapsed;
                    break;
                case "VRA":
                    //btn_Users.Visibility = Visibility.Collapsed;
                    //btnGanado.Visibility = Visibility.Collapsed;
                    //btnTransacciones.Visibility = Visibility.Collapsed;
                    break;
            }
        }



       
    }
}