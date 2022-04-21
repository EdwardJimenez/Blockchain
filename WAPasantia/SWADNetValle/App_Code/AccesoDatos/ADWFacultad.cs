using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADWFacultad
/// </summary>
public class ADWFacultad
{
    public ADWFacultad()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public DTONFacultad Obtener_NFacultad_Id_Facultad(string Id_Facultad)
    {
        DTONFacultad dtoNFacultad = new DTONFacultad();
        try
        {
            Database DBSWADNETVALLE = SBaseDatos.BDSWADNETValle;
            DbCommand dbCommand = DBSWADNETVALLE.GetStoredProcCommand("NFacultad_O_Id_Facultad");
            DBSWADNETVALLE.AddInParameter(dbCommand, "Id_Facultad", DbType.String, Id_Facultad);
            DBSWADNETVALLE.LoadDataSet(dbCommand, dtoNFacultad, "WFacultad");
        }
        catch (Exception ex)
        {

            throw;
        }
        return dtoNFacultad;
    }
    public DTONFacultad Obtener_NFacultad()
    {
        DTONFacultad dtoNFacultad = new DTONFacultad();
        try
        {
            Database DBSWADNETVALLE = SBaseDatos.BDSWADNETValle;
            DbCommand dbCommand = DBSWADNETVALLE.GetStoredProcCommand("NFacultad_O");
            DBSWADNETVALLE.LoadDataSet(dbCommand, dtoNFacultad, "WFacultad");
        }
        catch (Exception ex)
        {

            throw;
        }
        return dtoNFacultad;
    }
}