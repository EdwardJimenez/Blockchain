using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;

/// <summary>
/// Descripción breve de ADBHelper
/// </summary>
public class ADBHelper
{
    #region Metodos Pulicos
    /// <summary>
    /// Retorna el ultimo ID segun el nombre de una tabla
    /// </summary>
    /// <param name="NombreTabla"></param>
    /// <returns></returns>
    public string UltimoID_O_NombreTablaSinElCaracterI(string NombreTabla)
    {
        string ultimoID = string.Empty;
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("UltimoID_O_NombreTablaSinElCaracterI");
            BDSWADNETIntEx.AddInParameter(dbCommand, "NombreTabla", DbType.String, NombreTabla);
            IDataReader reader = BDSWADNETIntEx.ExecuteReader(dbCommand);
            while (reader.Read())
            {
                ultimoID = reader.GetValue(0).ToString();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return ultimoID;
    }
    /// <summary>
    /// Retorna el siguiente ID segun el nombre de una tabla
    /// </summary>
    /// <param name="NombreTabla"></param>
    /// <returns></returns>
    public string SiguienteID_O_NombreTablaSinElCaracterI(string NombreTabla)
    {
        string siguienteID = string.Empty;
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("SiguienteID_O_NombreTablaSinElCaracterI");
            BDSWADNETIntEx.AddInParameter(dbCommand, "NombreTabla", DbType.String, NombreTabla);
            IDataReader reader = BDSWADNETIntEx.ExecuteReader(dbCommand);
            while (reader.Read())
            {
                siguienteID = reader.GetValue(0).ToString();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return siguienteID;
    }

    #endregion
}