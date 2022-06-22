using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADBCareer
/// </summary>
public class ADNCareer
{
    
    /// <summary>
    /// Obtienen los datos de la tabla Carrera para poder visualizarlos
    /// </summary>
    /// <returns></returns>

    public DTONCareer Obtener_Carrerra()
    {
        DTONCareer dTONCareer = new DTONCareer();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADNeTValle;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("NetValle_CareerUniversity_O_Pedro");
            BDSWADNETIntUn.LoadDataSet(dbCommand, dTONCareer, "CareerUniversity");
        }
        catch (Exception)
        {
            throw;
        }
        return dTONCareer;
    }

    /// <summary>
    /// Obtienen los datos de la tabla Carrera mediante su ID de la carrera para poder visualizarse
    /// </summary>
    /// <param name="Id_Carrera"></param>
    /// <returns></returns>
    public DTONCareer Obtener_Carrerra_O_ID_Pedro(string Id_Carrera)
    {
        DTONCareer dTONCareer = new DTONCareer();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADNeTValle;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("NetValle_CareerUniversity_O_Id_Pedro");
            BDSWADNETIntUn.AddInParameter(dbCommand, "id", DbType.String, Id_Carrera);
            BDSWADNETIntUn.LoadDataSet(dbCommand, dTONCareer, "CareerUniversity");
        }
        catch (Exception)
        {
            throw;
        }
        return dTONCareer;
    }
}