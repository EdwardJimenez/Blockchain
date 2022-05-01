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
    public DTOBAudit Obtener_Audit_O_idAudit(string Id_Audit)
    {
        //Metodo select por medio del ID
        DTOBAudit dtoBAudit = new DTOBAudit();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADNETIntUn;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("Audit_O_idAudit"); //PROCESO
            BDSWADBlockchain.AddInParameter(dbCommand, "idAudit", DbType.String , Id_Audit);
            BDSWADBlockchain.LoadDataSet(dbCommand, dtoBAudit, "Audit");

        }
        catch (Exception)
        {

            throw;
        }
        return dtoBAudit;
    }

}