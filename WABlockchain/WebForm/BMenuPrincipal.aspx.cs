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



        protected void btnBuscar_Click1(object sender, EventArgs e)
        {
            EBTittle tittle = new EBTittle();
            string faculty = txtBuscador.Text;

            GridView1.DataSource = null;
            GridView1.DataBind();


            try
            {
                List<EBTittle> lstTitle = new List<EBTittle>();

                //if (faculty!="" && fechaInicio==null && fechaFin==null)
                //{
                lstTitle = swLNBlockchainClient.Search_BTitle_Faculty_Carrer_Date(faculty).ToList();
                if (lstTitle.Count() == 0)
                {
                    lblmensaje.Text = "No se encontro el título";
                }
                else
                {
                    GridView1.DataSource = lstTitle;
                    GridView1.DataBind();
                    GridView1.SelectedIndex = 0;
                    lblmensaje.Text = "Título encontrado";
                }
                //}
                //else
                //{
                //    if(faculty == "" && fechaInicio != null && fechaFin != null)
                //        lstTitle = swLNBlockchainClient.Search_BTitle_Date(fechaInicio, fechaFin).ToList();
                //        if (lstTitle.Count() == 0)
                //        {
                //            lblmensaje.Text = "No se encontro el título";
                //        }
                //        else
                //        {
                //            GridView1.DataSource = lstTitle;
                //            GridView1.DataBind();
                //            GridView1.SelectedIndex = 0;
                //            lblmensaje.Text = "Título encontrado";
                //        }

                //}

            }
            catch (Exception ex)
            {

                lblmensaje.Text = ex.Message;
            }
        }

        protected void btnBuscarPorFecha_Click(object sender, EventArgs e)
        {
            EBTittle tittle = new EBTittle();
            //DateTime fechaInicio = DateTime.Parse(FechaInicio.SelectedDate.ToString("YYYYmmdd"));
            string fechaInicio = FechaInicio.SelectedDate.ToLongDateString();
           // string fech =fechaInicio.ToString("yyyy - MM - dd HH: mm:ss");
            string fechaFin = FechaFin.SelectedDate.ToString();

            //DateTime fechaFin = DateTime.Parse(FechaFin.SelectedDate.ToString("YYYYmmdd"));

            //DateTime fechaIw = DateTime.Parse(fechaInicio);
            //DateTime fechaI = DateTime.ParseExact(fechaInicio, "yyyy-MM-dd", null);
            //lblmensaje.Text = fechaI.Day + "" + fechaI.Month + "" + fechaI.Year;


            //string dateString = "10/16/2018";

            //DateTime dt = Convert.ToDateTime(fechaInicio, CultureInfo.InvariantCulture);

            string format = "MM/dd/yyyy";

            //DateTime dateTime = DateTime.ParseExact(fechaInicio, format, CultureInfo.InvariantCulture);
            //lblmensaje.Text = ""+fechaI;
            

            string fecha = "10/16/2018";
            string formato = "yyyy/MM/dd HH: mm: ss";//MM representa Mes, dd día e yyyy año

  bool result = DateTime.TryParseExact(fechaInicio, formato, null, System.Globalization.DateTimeStyles.None, out DateTime dt);

            //En caso de que result sea verdadero, implica que la fecha alojada en el string es válida.
            if (result)
            {
                //Console.WriteLine("La fecha es correcta y es {0}", dt.ToShortDateString());
                lblmensaje.Text = ""+dt.ToShortDateString();
            }
            //Caso contrario, la fecha es invalida.
            else
            {
                //Console.WriteLine("El formato de la fecha ingresada es incorrecta.");
                lblmensaje.Text = "El formato de la fecha ingresada es incorrecta.";
            }



            //Console.WriteLine(dateTime);

            //fechaInicio.ToString("yyyymmdd");
            //fechaFin.ToString("yyyymmdd");
            //DateTime fechaRecepMuestra = Convert.ToDateTime(FechaFin.ToString());
            //fechaRecepMuestra.Date.ToString();
            //fechaInicio.ToString("yyyy-MM-dd");
            //fechaFin.ToString("yyyy-MM-dd");

            //    GridView1.DataSource = null;
            //    GridView1.DataBind();


            //    try
            //    {
            //        List<EBTittle> lstTitle = new List<EBTittle>();


            //        lstTitle = swLNBlockchainClient.Search_BTitle_Date(fechaInicio, fechaFin).ToList();
            //        if (lstTitle.Count() == 0)
            //        {
            //            lblmensaje.Text = "No se encontro el título";
            //        }
            //        else
            //        {
            //            GridView1.DataSource = lstTitle;
            //            GridView1.DataBind();
            //            GridView1.SelectedIndex = 0;
            //            lblmensaje.Text = "Título encontrado";
            //        }



            //    }
            //    catch (Exception ex)
            //    {

            //        lblmensaje.Text = ex.Message;
            //    }
        }
    }
}