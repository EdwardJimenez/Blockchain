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


    /// <summary>
    /// Obtiene los datos de los estudiantes
    /// </summary>
    /// <returns></returns>

    public DTONPerson Obtener_Persona_O_Estudiante()
    {
        DTONPerson dTONPerson = new DTONPerson();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADNeTValle;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("NetValle_Person_O_Estudent_Pedro");
            BDSWADNETIntUn.LoadDataSet(dbCommand, dTONPerson, "Person");
        }
        catch (Exception)
        {
            throw;
        }
        return dTONPerson;
    }
    /// <summary>
    /// Obtiene los datos del estudiante por medio de su nombre
    /// </summary>
    /// <param name="Fullname"></param>
    /// <returns></returns>
    public DTONPerson Obtener_Persona_O_Nombre(string Fullname)
    {
        DTONPerson dTONPerson = new DTONPerson();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADNeTValle;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("IPersona_O_Nombre");
            BDSWADNETIntUn.AddInParameter(dbCommand, "Nombre", DbType.String, Fullname);
            BDSWADNETIntUn.LoadDataSet(dbCommand, dTONPerson, "Person");
        }
        catch (Exception)
        {
            throw;
        }
        return dTONPerson;
    }


    /// <summary>
    /// Obtiene los datos del estudiante por medio de su ID
    /// </summary>
    /// <param name="ID"></param>
    /// <returns></returns>
    public DTONPerson Obtener_Persona_O_ID(int ID)
    {
        DTONPerson dTONPerson = new DTONPerson();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADNeTValle;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("NetValle_Person_O_ID");
            BDSWADNETIntUn.AddInParameter(dbCommand, "IDPerson", DbType.String, ID);
            BDSWADNETIntUn.LoadDataSet(dbCommand, dTONPerson, "Person");
        }
        catch (Exception)
        {
            throw;
        }
        return dTONPerson;
    }
    /// <summary>
    /// Obtiene los datos de todas las personas 
    /// </summary>
    /// <returns></returns>
    public DTONPerson Obtener_Person_O()
    {
        DTONPerson dTONPerson = new DTONPerson();
        try
        {
            Database BDSWADBlockchain = SBaseDatos.BDSWADNeTValle;
            DbCommand dbCommand = BDSWADBlockchain.GetStoredProcCommand("NetValle_Person_O");
            BDSWADBlockchain.LoadDataSet(dbCommand, dTONPerson, "Person");
        }
        catch (Exception)
        {

            throw;
        }
        return dTONPerson;
    }


    /// <summary>
    /// Obtiene a un usuario por medio de su Email y Contraseña
    /// </summary>
    /// <param name="Mail"></param>
    /// <param name="Password"></param>
    /// <returns></returns>

    public DTONPerson Obtener_Persona_O_Account(string Mail, string Password)
    {
        DTONPerson dTONPerson = new DTONPerson();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADNeTValle;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("NetValle_Persona_O_Account");
            BDSWADNETIntUn.AddInParameter(dbCommand, "Mail_Person", DbType.String, Mail);
            BDSWADNETIntUn.AddInParameter(dbCommand, "Password_Person", DbType.String, Password);
            BDSWADNETIntUn.LoadDataSet(dbCommand, dTONPerson, "Person");
        }
        catch (Exception)
        {
            throw;
        }
        return dTONPerson;
    }

    /// <summary>
    ///  Obtiene los datos de una persona por medio de su Rol
    /// </summary>
    /// <param name="Rol"></param>
    /// <returns></returns>
    public DTONPerson Obtener_Persona_O_Rol(string Rol)
    {
        DTONPerson dTONPerson = new DTONPerson();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADNeTValle;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("NetValle_Persona_O_Rol");
            BDSWADNETIntUn.AddInParameter(dbCommand, "Rol_Person", DbType.String, Rol);
            BDSWADNETIntUn.LoadDataSet(dbCommand, dTONPerson, "Person");
        }
        catch (Exception)
        {
            throw;
        }
        return dTONPerson;
    }


    /// <summary>
    /// Obtiene los datos de los estudiantes para agregarlos a un metodo complejo
    /// </summary>
    /// <returns></returns>
    public DTONPerson Obtener_Persona_O_EstudianteCompleto()
    {
        DTONPerson dTONPerson = new DTONPerson();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADNeTValle;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("NetValle_Persona_O_StudentComplety");
            BDSWADNETIntUn.LoadDataSet(dbCommand, dTONPerson, "Person");
        }
        catch (Exception)
        {
            throw;
        }
        return dTONPerson;
    }
}