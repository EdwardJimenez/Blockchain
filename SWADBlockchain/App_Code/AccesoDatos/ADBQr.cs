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
    #region MÉTODOS CRUD PROCEDIMIENTOS ALMACENADOS - QR
    public DTOBQrt Obtener_Qr_O()
    {
        DTOBQrt dTOBQr = new DTOBQrt();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BQr"); //Select * from QR
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
            Database BDSWADNETIntUn = SBaseDatos.BDSWADBlockchain;
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

    public void Insertar_BQr_I_Qr(EBQr bQr)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BQr_I_Qr");
            BDSWADNETIntEx.AddInParameter(dbCommand, "registerDate", DbType.DateTime, bQr.registerDate);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    /// <summary>
    /// Actualizar QR
    /// </summary>
    public void Actualizar_BQr_A_idQR_registerDate(EBQr bQR)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BQr_A_idQR_registerDate");
            BDSWADNETIntEx.AddInParameter(dbCommand, "idQR", DbType.String, bQR.IdQR);
            BDSWADNETIntEx.AddInParameter(dbCommand, "registerDate", DbType.DateTime, bQR.registerDate);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

}