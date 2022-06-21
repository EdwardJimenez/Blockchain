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

    /// <summary>
    /// Selecciona todos los roles
    /// </summary>
    /// <returns Retorna los roles de usuario existentes></returns>
    public DTOBRoluser Obtener_RolUser_O()
    {
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
    /// <summary>
    /// Obtiene el rol del usuario segun el ID
    /// </summary>
    /// <param idUser="Id_RolUser"></param>
    /// <returns Retorna el rol del usuario ></returns>
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
    /// <summary>
    /// Ingresa un nuevo rol
    /// </summary>
    /// <param EBRiluser="brolUser"></param>
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
    /// Actualiza el nombre del rol del usario
    /// </summary>
    /// <param EBRiluser="brolUser"></param>
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