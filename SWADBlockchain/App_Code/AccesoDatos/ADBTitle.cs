using Microsoft.Practices.EnterpriseLibrary.Data;
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
    public void BTittle_update_statusTittle_3(EBTittle bTitle)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BTittle_update_statusTittle_3");
            BDSWADNETIntEx.AddInParameter(dbCommand, "idTittle", DbType.String, bTitle.IdTittles);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void BTittle_update_statusTittle_4(EBTittle bTitle)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BTittle_update_statusTittle_4");
            BDSWADNETIntEx.AddInParameter(dbCommand, "idTittle", DbType.String, bTitle.IdTittles);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void BTittle_update_statusTittle_5(EBTittle bTitle)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BTittle_update_statusTittle_5");
            BDSWADNETIntEx.AddInParameter(dbCommand, "idTittle", DbType.String, bTitle.IdTittles);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
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
    public DTOBTitle BTittle_O_TO_Upload()
    {
        DTOBTitle dTOBTitle = new DTOBTitle();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BTittle_O_TO_Upload");
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBTitle, "BTittle");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOBTitle;
    }
    public DTOBTitle BTittle_O_State2()
    {
        DTOBTitle dTOBTitle = new DTOBTitle();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BTittle_O_State2"); //Select * from Title where status=5
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBTitle, "BTittle");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOBTitle;
    }
    public DTOBTitle BTittle_O_State3()
    {
        DTOBTitle dTOBTitle = new DTOBTitle();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BTittle_O_State3"); //Select * from Title where status=5
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBTitle, "BTittle");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOBTitle;
    }
    public DTOBTitle BTittle_O_State4()
    {
        DTOBTitle dTOBTitle = new DTOBTitle();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BTittle_O_State4"); //Select * from Title where status=5
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBTitle, "BTittle");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOBTitle;
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
    public DTOBTitle Obtener_Title_1()
    {
        DTOBTitle dTOBTitle = new DTOBTitle();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BTittle_O_statusTittle_1");
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBTitle, "BTittle");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOBTitle;
    }

    public DTOBTitle Obtener_Title_2()
    {
        DTOBTitle dTOBTitle = new DTOBTitle();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BTittle_O_statusTittle_2");
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
    public void Insertar_BTitle(EBTittle bTitle)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BTitle_Insert");
            BDSWADNETIntEx.AddInParameter(dbCommand, "id", DbType.String, bTitle.IdTittles);
            BDSWADNETIntEx.AddInParameter(dbCommand, "faculty", DbType.String, bTitle.faculty);
            BDSWADNETIntEx.AddInParameter(dbCommand, "carreer", DbType.String, bTitle.carreer);
            BDSWADNETIntEx.AddInParameter(dbCommand, "fullNameT", DbType.String, bTitle.fullNameTitulado);
            BDSWADNETIntEx.AddInParameter(dbCommand, "IdUser", DbType.String, bTitle.idUser);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    /// <summary>
    /// Busca un titulo con los siguientes parametros
    /// </summary>
    /// <param name="fullNameT"></param>
    /// /// <param name="carreer"></param>
    /// /// <param name="faculty"></param>
    /// <returns Retorna los datos de un titulo ></returns>
    public DTOBTitle Search_BTitle(string name, string carreer, string faculty)
    {
        DTOBTitle dTOBTitle = new DTOBTitle();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BTitle_S_SearchTitle");
            BDSWADBlockchain.AddInParameter(dbCommand, "fullNameT", DbType.String, name);
            BDSWADBlockchain.AddInParameter(dbCommand, "faculty", DbType.String, faculty);
            BDSWADBlockchain.AddInParameter(dbCommand, "carreer", DbType.String, carreer);
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBTitle, "BTittle");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOBTitle;
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

    /// <summary>
    /// Actualizar Title statusTitleTo1
    /// </summary>
    public void Actualizar_ITitle_statusTitle_1(EBTittle bTitle)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BTittle_U_statusTittle_1");
            BDSWADNETIntEx.AddInParameter(dbCommand, "id", DbType.String, bTitle.IdTittles);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    /// <summary>
    /// Actualizar Title statusTitle to 2
    /// </summary>
    public void Actualizar_ITitle_statusTitle_2(EBTittle bTitle)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BTittle_update_statusTittle_2");
            BDSWADNETIntEx.AddInParameter(dbCommand, "id", DbType.String, bTitle.IdTittles);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    /// <summary>
    /// Eliminar Title statusTitleToFive
    /// </summary>
    public void Eliminar_ITitle_statusTitle(EBTittle bTitle)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BTittle_Delet_statusTittle");
            BDSWADNETIntEx.AddInParameter(dbCommand, "id", DbType.String, bTitle.IdTittles);
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
    public void Actualizar_ITitle(EBTittle bTitle)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BTittle_Update");
            BDSWADNETIntEx.AddInParameter(dbCommand, "id", DbType.String, bTitle.IdTittles);
            BDSWADNETIntEx.AddInParameter(dbCommand, "faculty", DbType.String, bTitle.faculty);
            BDSWADNETIntEx.AddInParameter(dbCommand, "carreer", DbType.String, bTitle.carreer);
            BDSWADNETIntEx.AddInParameter(dbCommand, "fullNameT", DbType.String, bTitle.fullNameTitulado);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Actualizar_BTittle_ConfirmarEntrega(EBTittle bTitle)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BTittle_U_ConfirmarEntrega");
            BDSWADNETIntEx.AddInParameter(dbCommand, "fullname", DbType.String, bTitle.fullNameTitulado);
            BDSWADNETIntEx.AddInParameter(dbCommand, "fecha", DbType.Date, bTitle.dateDelivery);
            BDSWADNETIntEx.AddInParameter(dbCommand, "modo", DbType.String, bTitle.statusDelivery);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }


    public DTOBTitle Search_BTitle_Faculty_Carrer_Date(string txt)
    {
        DTOBTitle dTOBTitle = new DTOBTitle();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BTittle_S_Search_Faculty_Carreer_Date");
            BDSWADBlockchain.AddInParameter(dbCommand, "txt", DbType.String, txt);
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBTitle, "BTittle");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOBTitle;
    }

    public DTOBTitle Search_BTitle_Date(DateTime fechaInicio, DateTime fechaFin)
    {
        DTOBTitle dTOBTitle = new DTOBTitle();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BTittle_S_Search_Date");
            BDSWADBlockchain.AddInParameter(dbCommand, "Inicio", DbType.DateTime, fechaInicio);
            BDSWADBlockchain.AddInParameter(dbCommand, "Fin", DbType.DateTime, fechaFin);
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBTitle, "BTittle");
        }
        catch (Exception)
        {
            throw;
        }
        return dTOBTitle;
    }

}