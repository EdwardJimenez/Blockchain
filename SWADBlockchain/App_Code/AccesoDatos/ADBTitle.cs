﻿using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Common;
using System.Data;
/// <summary>
/// Descripción breve de ADBTitle
/// </summary>
public class ADBTitle
{
    public DTOBTitle Obtener_Title_O()
    {
        DTOBTitle dTOBTitle = new DTOBTitle();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADNETIntUn;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BTitle"); //Select * from Title
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBTitle, "Title");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOBTitle;
    }
    /// <summary>
    /// Acceso a datos mediante Id_Carrera
    /// </summary>
    /// <param name="Id_title"></param>
    /// <returns Retorna una titulo></returns>
    public DTOBTitle Obtener_BTitle_O_idTitle(string Id_title)
    {
        DTOBTitle dtoBTitle = new DTOBTitle();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADNETIntUn;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("BTitle_O_idTitle");
            BDSWADNETIntUn.AddInParameter(dbCommand, "idTitle", DbType.String, Id_title);
            BDSWADNETIntUn.LoadDataSet(dbCommand, dtoBTitle, "BTitle");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoBTitle;
    }
    //  Corregir esto!!,esta bien que copies pero no lo subas asi, genera errores en el github

    public void Insertar_BTitle_I_idTitle_faculty(EBTittle bTitle)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADNETIntUn;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BTitle_I_idTitle_faculty");
            BDSWADNETIntEx.AddInParameter(dbCommand, "faculty", DbType.String, bTitle);
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
    public void Actualizar_BTitle_A_idTitle_faculty(EBTittle bTitle)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADNETIntUn;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BTitle_A_idTitle_faculty");
            BDSWADNETIntEx.AddInParameter(dbCommand, "idTitle", DbType.String, bTitle.IdTittles);
            BDSWADNETIntEx.AddInParameter(dbCommand, "faculty", DbType.String, bTitle.faculty);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    /// <summary>
    /// Acceso a datos mediante Id_Carrera
    /// </summary>
    /// <param name="statusTitle"></param>
    /// <returns Retorna los titulos con estado 4 ></returns>
    public DTOBTitle Obtener_BTitle_O_statusTitle()
    {
        DTOBTitle dtoBTitle = new DTOBTitle();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADNETIntUn;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("BTittle_statusTittle");
            BDSWADNETIntUn.LoadDataSet(dbCommand, dtoBTitle, "BTittle");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoBTitle;
    }

    /// <summary>
    /// Actualizar Title statusTittle
    /// </summary>
    public void Actualizar_BTitle_A_statusTittle(EBTittle bTitle)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADNETIntUn;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BTittle_update_statusTittle");
            BDSWADNETIntEx.AddInParameter(dbCommand, "IdTittles", DbType.String, bTitle.IdTittles);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
}