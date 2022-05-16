﻿using Microsoft.Practices.EnterpriseLibrary.Data;
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

    //Pedro Conde: Estoy usando un procedimiento almacenado creado por mi para probar

    public DTONPerson Obtener_Persona_O_Estudiante(string rol_person)
    {
        DTONPerson dTONPerson = new DTONPerson();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADNeTValle;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("NetValle_Person_O_Estudent_Pedro");
            BDSWADNETIntUn.AddInParameter(dbCommand, "Rol_Person", DbType.String, rol_person);
            BDSWADNETIntUn.LoadDataSet(dbCommand, dTONPerson, "Person");
        }
        catch (Exception)
        {
            throw;
        }
        return dTONPerson;
    }

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

    public DTONPerson Obtener_Persona_O_ID(string ID_Person)
    {
        DTONPerson dTONPerson = new DTONPerson();
        try
        {
            Database BDSWADNETIntUn = SBaseDatos.BDSWADNeTValle;
            DbCommand dbCommand = BDSWADNETIntUn.GetStoredProcCommand("NetValle_Persona_O_ID");
            BDSWADNETIntUn.AddInParameter(dbCommand, "IDPerson", DbType.String, ID_Person);
            BDSWADNETIntUn.LoadDataSet(dbCommand, dTONPerson, "Person");
        }
        catch (Exception)
        {
            throw;
        }
        return dTONPerson;
    }

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