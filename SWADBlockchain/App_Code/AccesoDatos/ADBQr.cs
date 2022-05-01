using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;

/// <summary>
/// Descripción breve de ADBQr
/// </summary>
public class ADBQr
{
    public DTOBQrt Obtener_Qr_O()
    {
        DTOBQrt dTOBQr = new DTOBQrt();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADNETIntUn;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BQr"); //Select * from Person
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBQr, "BQr");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOBQr;
    }

    public DTOBQrt Obtener_BQr_O_idQR(string Id_Qr)
    {
        DTOBQrt dTOBQr = new DTOBQrt();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADNETIntUn;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("BQr_O_idQR");
            BDSWADNETIntUn.AddInParameter(dbCommand, "idQR", DbType.String, Id_Qr);
            BDSWADNETIntUn.LoadDataSet(dbCommand, dTOBQr, "BQr");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOBQr;
    }


}