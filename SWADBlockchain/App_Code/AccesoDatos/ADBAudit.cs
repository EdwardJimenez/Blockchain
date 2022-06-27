using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADBidAudit
/// </summary>
public class ADBidAudit
{
    #region

    /// <summary>
    /// Este Método realiza la consulta: Select * from Audit a la Base de datos mediante un procedimiento almacenado,
    /// retornando los datos obtenidos
    /// </summary>
    /// <returns></returns>
    public DTOBAudit Obtener_Audit_O()
    {
        DTOBAudit dtoBAudit = new DTOBAudit();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("Audit_O"); 
            BDSWADBlockchain.LoadDataSet(dbCommand, dtoBAudit, "BAudit");
        }
        catch (Exception)
        {

            throw;
        }
        return dtoBAudit;
    }

    /// <summary>
    /// Método que realiza una consulta select por medio de un ID mediante un procedimiento almacenado
    /// </summary>
    /// <param name="Id_Audit"></param>
    /// <returns></returns>
    public DTOBAudit Obtener_Audit_O_idAudit(string Id_Audit)
    {
        DTOBAudit dtoBAudit = new DTOBAudit();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("Audit_O_idAudit"); 
            BDSWADBlockchain.AddInParameter(dbCommand, "idAudit", DbType.String, Id_Audit);
            BDSWADBlockchain.LoadDataSet(dbCommand, dtoBAudit, "BAudit");

        }
        catch (Exception)
        {

            throw;
        }
        return dtoBAudit;
    }

    /// <summary>
    /// Método que realiza la inserción de un registro mediante un procedimiento almacenado, 
    /// el campo a insertar es la descripción
    /// </summary>
    /// <param name="bAudit"></param>
    public void Insertar_BAudit_I_Nombre(EBAudit bAudit)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BAudit_Nombre");
            BDSWADNETIntEx.AddInParameter(dbCommand, "description", DbType.String, bAudit.description);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// Actualizar el campo: Descripción, de la tabla: Auditoria
    /// </summary>
    public void Actualizar_BAudit_A_idAudit_Descripción(EBAudit bAudit)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BAudit_A_idAudit_Descripción");
            BDSWADNETIntEx.AddInParameter(dbCommand, "idAudit", DbType.String, bAudit.IdAudit);
            BDSWADNETIntEx.AddInParameter(dbCommand, "description", DbType.String, bAudit.description);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion


}