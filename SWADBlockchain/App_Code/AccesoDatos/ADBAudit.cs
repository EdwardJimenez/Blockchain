﻿using Microsoft.Practices.EnterpriseLibrary.Data;
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

    public DTOBAudit Obtener_Audit_O()
    {
        DTOBAudit dtoBAudit = new DTOBAudit();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("Audit_O"); //Select * from Audit
            BDSWADBlockchain.LoadDataSet(dbCommand, dtoBAudit, "BAudit");
        }
        catch (Exception)
        {

            throw;
        }
        return dtoBAudit;
    }
    public DTOBAudit Obtener_Audit_O_idAudit(string Id_Audit)
    {
        //Metodo select por medio del ID
        DTOBAudit dtoBAudit = new DTOBAudit();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("Audit_O_idAudit"); //PROCESO
            BDSWADBlockchain.AddInParameter(dbCommand, "idAudit", DbType.String, Id_Audit);
            BDSWADBlockchain.LoadDataSet(dbCommand, dtoBAudit, "BAudit");

        }
        catch (Exception)
        {

            throw;
        }
        return dtoBAudit;
    }

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
    /// Actualizar Descripción Auditoria
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