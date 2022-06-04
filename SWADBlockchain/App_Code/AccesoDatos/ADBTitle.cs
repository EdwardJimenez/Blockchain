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
    public DTOBTitle BUser_O_Search(string name)
    {
        //
        //Metodo select por medio del name
        //
        DTOBTitle dTOBTittle = new DTOBTitle();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;

            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BUser_O_Search"); //Select name from tittle
            BDSWADBlockchain.AddInParameter(dbCommand, "fullname", DbType.String, name);
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBTittle, "BTittle");

        }
        catch (Exception)
        {

            throw;
        }
        return dTOBTittle;
    }

    public DTOBTitle BTittle_O_Faculty(string faculty)
    {
        //
        //Metodo select por medio del name
        //
        DTOBTitle dTOBTittle = new DTOBTitle();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;

            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BTittle_O_Faculty"); //Select name from tittle
            BDSWADBlockchain.AddInParameter(dbCommand, "faculty", DbType.String, faculty);
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBTittle, "BTittle");

        }
        catch (Exception)
        {

            throw;
        }
        return dTOBTittle;
    }

    public DTOBTitle BTittle_O_CARREER(string carreer)
    {
        //
        //Metodo select por medio del name
        //
        DTOBTitle dTOBTittle = new DTOBTitle();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;

            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BTittle_O_CARREER"); //Select name from tittle
            BDSWADBlockchain.AddInParameter(dbCommand, "carreer", DbType.String, carreer);
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBTittle, "BTittle");

        }
        catch (Exception)
        {

            throw;
        }
        return dTOBTittle;
    }
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
    //se debe terminar esto
    public DTOBTitle BTittle_O_Select_Faculty()
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

    public DTOBTitle Obtener_Title_O_ListGraduates()
    {
        DTOBTitle dTOBTitle = new DTOBTitle();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BTittle_O_ListGraduates"); //Select * from Title in general
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

    public DTOBTitle Obtener_BTitle_O_career(string career)
    {
        DTOBTitle dtoBTitle = new DTOBTitle();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("Obtener_BTitle_O_career");
            BDSWADNETIntUn.AddInParameter(dbCommand, "idTitle", DbType.String, career);
            BDSWADNETIntUn.LoadDataSet(dbCommand, dtoBTitle, "BTitle");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoBTitle;
    }

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
}