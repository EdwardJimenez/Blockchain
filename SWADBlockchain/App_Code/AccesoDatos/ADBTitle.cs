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
    public void BTittle_update_statusTittle_7(EBTittle bTitle)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BTittle_update_statusTittle_7");
            BDSWADNETIntEx.AddInParameter(dbCommand, "idTittle", DbType.String, bTitle.IdTittles);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void BTittle_update_statusTittle_6(EBTittle bTitle)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BTittle_update_statusTittle_6");
            BDSWADNETIntEx.AddInParameter(dbCommand, "idTittle", DbType.String, bTitle.IdTittles);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public DTOBTitle BTittle_O_State5()
    {
        DTOBTitle dTOBTitle = new DTOBTitle();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BTittle_O_State5"); //Select * from Title where status=5
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBTitle, "BTittle");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOBTitle;
    }
    public DTOBTitle BTittle_O_State6()
    {
        DTOBTitle dTOBTitle = new DTOBTitle();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BTittle_O_State6"); //Select * from Title where status=6
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBTitle, "BTittle");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOBTitle;
    }
    public DTOBTitle BTittle_O_State7()
    {
        DTOBTitle dTOBTitle = new DTOBTitle();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BTittle_O_State7"); //Select * from Title where status=7
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBTitle, "BTittle");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOBTitle;
    }
    public DTOBTitle Obtener_Title_O()
    {
        DTOBTitle dTOBTitle = new DTOBTitle();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BTittle_statusTittle"); //Select * from Title
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBTitle, "BTittle");
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
            Database BDSWADNETIntUn = SBaseDatos.BDSWADBlockchain;
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
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
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
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
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
    /// Actualizar Title statusTitleToFive
    /// </summary>
    public void Actualizar_ITitle_statusTitle(EBTittle bTitle)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BTittle_update_statusTittle");
            BDSWADNETIntEx.AddInParameter(dbCommand, "id", DbType.String, bTitle.IdTittles);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
}