using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ADNPerson
/// </summary>
public class ADNPerson
{
    public DTONPerson Obtener_Person_O()
    {
        DTONPerson dTONPerson = new DTONPerson();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADNeTValle;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("");
            BDSWADBlockchain.LoadDataSet(dbCommand, dTONPerson, "");
        }
        catch (Exception)
        {

            throw;
        }
        return dTONPerson;
    }

    public DTONPerson Obtener_BPersona_O_IDPersona(string ID_Person)
    {
        DTONPerson dtoBPersona = new DTONPerson();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADNeTValle;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("");
            BDSWADNETIntUn.AddInParameter(dbCommand, "IDPerson", DbType.String, ID_Person);
            BDSWADNETIntUn.LoadDataSet(dbCommand, dtoBPersona, "Person");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoBPersona;
    }
}