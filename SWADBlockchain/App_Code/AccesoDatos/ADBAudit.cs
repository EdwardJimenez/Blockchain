using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;

/// <summary>
/// Descripción breve de ADBidAudit
/// </summary>
public class ADBidAudit
{
    #region

    public DTOBAudit Obtener_Person_O()
    {
        DTOBAudit dtoBAudit = new DTOBAudit();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADNETIntUn;
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
            Database BDSWADBlockchain = SBaseDatos.BDSWADNETIntUn;
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

    public void Insertar_BAudit_I_NombreCarrera(EICarrera eICarrera)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADNETIntEx;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("ICarrera_I_NombreCarrera");
            BDSWADNETIntEx.AddInParameter(dbCommand, "NombreCarrera", DbType.String, eICarrera.NombreCarrera);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    /// <summary>
    /// Actualizar Nombre Carrera
    /// </summary>
    public void Actualizar_ICarrera_A_CarreraID_NombreCarrera(EICarrera eICarrera)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADNETIntEx;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("ICarrera_A_CarreraID_NombreCarrera");
            BDSWADNETIntEx.AddInParameter(dbCommand, "CarreraID", DbType.String, eICarrera.Id_Carrera);
            BDSWADNETIntEx.AddInParameter(dbCommand, "NombreCarrera", DbType.String, eICarrera.NombreCarrera);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion


}