using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;

/// <summary>
/// Descripción breve de ADBRolUser
/// </summary>
public class ADBRolUser
{
    #region MÉTODOS CRUD PROCEDIMIENTOS ALMACENADOS - ROLUSER

    public DTOBRoluser Obtener_RolUser_O()
    {
        //
        //Metodo select por medio del ID
        //
        DTOBRoluser dTOBRolUser = new DTOBRoluser();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BRolUser_O"); //Select * from RolUser
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBRolUser, "BRolUser");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOBRolUser;
    }

    public DTOBRoluser Obtener_BRolUser_O_idrolUser(string Id_RolUser)
    {
        DTOBRoluser dtoBRolUser = new DTOBRoluser();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("BRolUser_O_idrolUser");
            BDSWADNETIntUn.AddInParameter(dbCommand, "idrolUser", DbType.String, Id_RolUser);
            BDSWADNETIntUn.LoadDataSet(dbCommand, dtoBRolUser, "BRolUser");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoBRolUser;
    }

    public void Insertar_BRolUser_A_idrolUser_name(EBRoluser brolUser)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BRolUser_A_idrolUser_name");
            BDSWADNETIntEx.AddInParameter(dbCommand, "name", DbType.String, brolUser);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    /// <summary>
    /// Actualizar RolUser
    /// </summary>
    public void Actualizar_BRolUser_A_idrolUser_name(EBRoluser brolUser)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BRolUser_A_idrolUser_name");
            BDSWADNETIntEx.AddInParameter(dbCommand, "idrolUser", DbType.String, brolUser.idrolUser);
            BDSWADNETIntEx.AddInParameter(dbCommand, "name", DbType.String, brolUser.name);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
        #endregion
    }