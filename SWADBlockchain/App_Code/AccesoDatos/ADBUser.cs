using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;


/// <summary>
/// Descripción breve de ADBUser
/// </summary>
public class ADBUser
{
    public DTOBUser Obtener_User_O()
    {
        //
        //Metodo select por medio del ID
        //
        DTOBUser dTOBUser = new DTOBUser();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADNETIntUn;

            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BUser"); //Select * from User
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBUser, "BUser");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOBUser;
    }

    public DTOBUser Obtener_BUser_O_iduser(string iduser)
    {
        DTOBUser dtoBUser = new DTOBUser();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADNETIntUn;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("BUser_O_iduser");
            BDSWADNETIntUn.AddInParameter(dbCommand, "iduser", DbType.String, iduser);
            BDSWADNETIntUn.LoadDataSet(dbCommand, dtoBUser, "BUser");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoBUser;
    }

    public void Insertar_BUser_I_idUser_email(EBUser bUser)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADNETIntUn;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BUser_I_idUser_email");
            BDSWADNETIntEx.AddInParameter(dbCommand, "email", DbType.String, bUser.Email);
            BDSWADNETIntEx.AddInParameter(dbCommand, "password", DbType.String, bUser.Password);
            BDSWADNETIntEx.AddInParameter(dbCommand, "userNetvalle", DbType.String, bUser.UserNetvalle);
            BDSWADNETIntEx.AddInParameter(dbCommand, "IdrolUser", DbType.String, bUser.IdRolUser);
            BDSWADNETIntEx.AddInParameter(dbCommand, "Tittle_IdTittles", DbType.String, bUser.IdTitle);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
            
        }
        catch (Exception)
        {
            throw;
        }
    }
    /// <summary>
    /// Actualizar Title
    /// </summary>
    public void Actualizar_BUser_I_idUser_email(EBUser bUser)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADNETIntUn;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BUser_I_idUser_email");
            BDSWADNETIntEx.AddInParameter(dbCommand, "idUser", DbType.String, bUser.IdUser);
            BDSWADNETIntEx.AddInParameter(dbCommand, "email", DbType.String, bUser.Email);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
}