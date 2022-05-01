using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;
/// <summary>
/// Descripción breve de ADBPerson
/// </summary>
public class ADBPerson
{
    public DTOBPerson Obtener_Person_O()
    {
        DTOBPerson dTOBPerson = new DTOBPerson();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADNETIntUn;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BPerson"); //Select * from Person
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBPerson, "BPerson");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOBPerson;
    }
   
    public DTOBPerson Obtener_BPersona_O_idPersona(string Id_Carrera)
    {
        DTOBPerson dtoBPersona = new DTOBPerson();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADNETIntUn;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("BPersona_O_idPersona");
            BDSWADNETIntUn.AddInParameter(dbCommand, "idPerson", DbType.String, Id_Carrera);
            BDSWADNETIntUn.LoadDataSet(dbCommand, dtoBPersona, "BPerson");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoBPersona;
    }
}