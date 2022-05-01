using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;

/// <summary>
/// Descripción breve de ADBRolUser
/// </summary>
public class ADBRolUser
{
    #region Métodos

    public DTOBRoluser Obtener_RolUser_O()
    {
        //
        //Metodo select por medio del ID
        //
        DTOBRoluser dTOBRolUser = new DTOBRoluser();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADNETIntUn;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BRolUser"); //Select * from RolUser
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBRolUser, "BRolUser");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOBRolUser;
    }

    public DTOBRoluser Obtener_BRolUser_O_idrolUser(string Id_Carrera)
    {
        DTOBRoluser dtoBRolUser = new DTOBRoluser();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADNETIntUn;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("BRolUser_O_idrolUser");
            BDSWADNETIntUn.AddInParameter(dbCommand, "idrolUser", DbType.String, Id_Carrera);
            BDSWADNETIntUn.LoadDataSet(dbCommand, dtoBRolUser, "BRolUser");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoBRolUser;
    }
    #endregion
}