using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data;
/// <summary>
/// Descripción breve de ADBPerson
/// </summary>
public class ADBPerson
{
    #region METODOS CRUD MEDIANTE PROCEDIMIENTOS ALMACENADOS - PERSONA
    public DTOBPerson Obtener_Person_O()
    {
        DTOBPerson dTOBPerson = new DTOBPerson();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("BPerson"); //Select * from Person
            BDSWADBlockchain.LoadDataSet(dbCommand, dTOBPerson, "BPerson");
        }
        catch (Exception)
        {

            throw;
        }
        return dTOBPerson;
    }

    public DTOBPerson Obtener_BPersona_O_idPersona(string Id_Person)
    {
        DTOBPerson dtoBPersona = new DTOBPerson();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("BPersona_O_idPersona");
            BDSWADNETIntUn.AddInParameter(dbCommand, "idPerson", DbType.String, Id_Person);
            BDSWADNETIntUn.LoadDataSet(dbCommand, dtoBPersona, "BPerson");
        }
        catch (Exception)
        {
            throw;
        }
        return dtoBPersona;
    }

    public void Insertar_BPerson_I_FullName(EBPerson bPerson)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BPerson_FullName");
            BDSWADNETIntEx.AddInParameter(dbCommand, "FullName", DbType.String, bPerson.fullName);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    /// <summary>
    /// Actualizar Persona
    /// </summary>
    public void Actualizar_BPersona_A_idPersona_fullName(EBPerson bPerson)
    {
        try
        {
            Database BDSWADNETIntEx = SBaseDatos.BDSWADBlockchain;
            DbCommand dbCommand = BDSWADNETIntEx.GetStoredProcCommand("BPersona_A_idPersona_fullName");
            BDSWADNETIntEx.AddInParameter(dbCommand, "idPerson", DbType.String, bPerson.IdPerson);
            BDSWADNETIntEx.AddInParameter(dbCommand, "fullName", DbType.String, bPerson.fullName);
            BDSWADNETIntEx.ExecuteNonQuery(dbCommand);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}