using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;

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
    /// <param name="Id_Carrera"></param>
    /// <returns Retorna una carrera></returns>
    /* public DTOICarrera Obtener_ICarrera_O_CarreraID(string Id_Carrera)
    {
        DTOICarrera dtoICarrera = new DTOICarrera();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADNETIntUn;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("ICarrera_O_CarreraID");
            BDSWADNETIntUn.AddInParameter(dbCommand, "CarreraID", DbType.String, Id_Carrera);
            BDSWADNETIntUn.LoadDataSet(dbCommand, dtoICarrera, "ICarrera");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoICarrera;
    }*/ 
    //  Corregir esto!!,esta bien que copies pero no lo subas asi, genera errores en el github
}