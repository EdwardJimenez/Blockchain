using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADWCiudad
/// </summary>
public class ADWCiudad
{
    public DTONCiudad Obtener_NCiudad()
    {
        DTONCiudad dtoNCiudad = new DTONCiudad();
        try
        {
            Database DBSWADNETVALLE = SBaseDatos.BDSWADNETValle;
            DbCommand dbCommand = DBSWADNETVALLE.GetStoredProcCommand("NCiudad_O");
            DBSWADNETVALLE.LoadDataSet(dbCommand, dtoNCiudad, "WCiudad");
        }
        catch (Exception ex)
        {

            throw;
        }
        return dtoNCiudad;
    }

    public DTONCiudad Obtener_NCiudad_Id_Ciudad(string Id_Ciudad)
    {
        DTONCiudad dtoNCiudad = new DTONCiudad();
        try
        {
            Database DBSWADNETVALLE = SBaseDatos.BDSWADNETValle;
            DbCommand dbCommand = DBSWADNETVALLE.GetStoredProcCommand("NCiudad_O_Id_Ciudad");
            DBSWADNETVALLE.AddInParameter(dbCommand, "Id_Ciudad", DbType.String, Id_Ciudad);
            DBSWADNETVALLE.LoadDataSet(dbCommand, dtoNCiudad, "WCiudad");
        }
        catch (Exception ex)
        {

            throw;
        }
        return dtoNCiudad;
    }
}