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

    /// <summary>
    /// Método que realiza la consulta: Select * from QR, retornando los datos obtenidos
    /// </summary>
    /// <returns></returns>
    public DTOBQrt Obtener_Qr_O()
    {
        DTOBQrt dTOBQr = new DTOBQrt();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BQr"); 
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBQr, "BQr");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOBQr;
    }


    /// <summary>
    /// Método que realiza la consulta de obtener lo datos de la tabla: Qr, mediante el ID
    /// </summary>
    /// <param name="Id_Qr"></param>
    /// <returns></returns>
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


    /// <summary>
    /// Método que realiza la inserción de datos: registerDate, a la tabla Qr
    /// </summary>
    /// <param name="bQr"></param>
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
    /// Actualizar la tabla: QR por medio del dato: registerDate
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