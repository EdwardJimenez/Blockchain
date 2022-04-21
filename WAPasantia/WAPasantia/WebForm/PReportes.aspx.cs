using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WAPasantia.Reportes;

namespace WAPasantia.WebForm
{
    public partial class PReportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ReportG_Click(object sender, EventArgs e)
        {
            ReportDocument rp = new ReportDocument();
            rp.Load(Server.MapPath("../Reportes/ReporteGeneral.rpt"));
            rp.SetParameterValue("@CACA", "INFORMATICA");
            rp.SetDatabaseLogon("sa", "Univalle", "localhost", "NETPAS");
            rp.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "person information");
        }

        protected void ReportGFECHA_Click(object sender, EventArgs e)
        {
            if (txtyear.Text != "")
            {
                int year = int.Parse(txtyear.Text);
                DateTime primerDia = new DateTime(year, 1, 1);
                DateTime ultimoDIa = primerDia.AddYears(1).AddTicks(-1);
                ReportDocument rp = new ReportDocument();
                rp.Load(Server.MapPath("../Reportes/RGeneralFecha.rpt"));
                rp.SetParameterValue("@FECHA1", primerDia.ToString("dd/MM/yyyy"));
                rp.SetParameterValue("@FECHA2", ultimoDIa.ToString("dd/MM/yyyy"));
                rp.SetDatabaseLogon("sa", "Univalle", "localhost", "NETPAS");
                rp.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "person information");
            }


        }

        protected void ReportFac_Click(object sender, EventArgs e)
        {
            if (cbFacultad1.Text != "")
            {
                string facultad = cbFacultad1.Text;
                ReportDocument rp = new ReportDocument();
                rp.Load(Server.MapPath("../Reportes/ReporteFacultad.rpt"));
                rp.SetParameterValue("@SEDE", facultad);
                rp.SetDatabaseLogon("sa", "Univalle", "localhost", "NETPAS");
                rp.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "person information");

            }
        }

        protected void ReporteFacFecha_Click(object sender, EventArgs e)
        {
            if (CbFacultad2.Text != "")
            {
                if (txtyear2.Text != "")
                {
                    string facultad = CbFacultad2.Text;
                    int year = int.Parse(txtyear.Text);
                    DateTime primerDia = new DateTime(year, 1, 1);
                    DateTime ultimoDIa = primerDia.AddYears(1).AddTicks(-1);
                    ReportDocument rp = new ReportDocument();
                    rp.Load(Server.MapPath("../Reportes/RFacultadFecha.rpt"));
                    rp.SetParameterValue("@SEDE", facultad);
                    rp.SetParameterValue("@FECHA1", primerDia.ToString("dd/MM/yyyy"));
                    rp.SetParameterValue("@FECHA2", ultimoDIa.ToString("dd/MM/yyyy"));
                    rp.SetDatabaseLogon("sa", "Univalle", "localhost", "NETPAS");
                    rp.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "person information");
                }

            }

        }
    }
}