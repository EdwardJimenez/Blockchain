﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CNPerson
/// </summary>
public class CNPerson
{
    private ADNPerson aDNPerson;
    public CNPerson()
    {
        aDNPerson = new ADNPerson();
    }

    public List<ENPersona> Obtener_Persona_O()
    {
        ENPersona eNPersona = new ENPersona();
        List<ENPersona> lstNPersona = new List<ENPersona>();
        DTONPerson dTONPerson = aDNPerson.Obtener_Person_O();
        foreach (DTONPerson.PersonRow drPersona in dTONPerson.Person.Rows)
        {
            eNPersona = new ENPersona();
            eNPersona.IDPerson = drPersona.IDPerson.ToString().TrimEnd();
            eNPersona.FirstName = drPersona.First_Name_Person.ToString().TrimEnd();
            eNPersona.SecondName = drPersona.Second_Name_Person.ToString().TrimEnd();
            eNPersona.LastName = drPersona.LastName_Person.ToString().TrimEnd();
            eNPersona.SecondLastName = drPersona.Second_LastName_Person.ToString().TrimEnd();
            eNPersona.CI = drPersona.CI_Person.ToString().TrimEnd();
            eNPersona.ExtCI = drPersona.Ext_CI_Person.ToString().TrimEnd();
            eNPersona.Phone = drPersona.Phone_Person.ToString().TrimEnd();
            eNPersona.Rol = drPersona.Rol_Person.ToString().TrimEnd();
            lstNPersona.Add(eNPersona);
        }
        return lstNPersona;
    }

    public ENPersona Obtener_Persona_O_ID(string IDPerson)
    {
        ENPersona eNPersona = new ENPersona();
        DTONPerson dTONPerson = aDNPerson.Obtener_Persona_O_ID(IDPerson);
        foreach (DTONPerson.PersonRow drPersona in dTONPerson.Person.Rows)
        {
            eNPersona = new ENPersona();
            eNPersona.IDPerson = drPersona.IDPerson.ToString().TrimEnd();
            eNPersona.FirstName = drPersona.First_Name_Person.ToString().TrimEnd();
            eNPersona.SecondName = drPersona.Second_Name_Person.ToString().TrimEnd();
            eNPersona.LastName = drPersona.LastName_Person.ToString().TrimEnd();
            eNPersona.SecondLastName = drPersona.Second_LastName_Person.ToString().TrimEnd();
            eNPersona.CI = drPersona.CI_Person.ToString().TrimEnd();
            eNPersona.ExtCI = drPersona.Ext_CI_Person.ToString().TrimEnd();
            eNPersona.Phone = drPersona.Phone_Person.ToString().TrimEnd();
            eNPersona.Rol = drPersona.Rol_Person.ToString().TrimEnd();
        }
        return eNPersona;
    }

    public List<ENPersona> Obtener_Persona_O_Estudiante()
    {
        ENPersona eNPersona = new ENPersona();
        List<ENPersona> lstNPersona = new List<ENPersona>();
        DTONPerson dTONPerson = aDNPerson.Obtener_Persona_O_Estudiante();
        foreach (DTONPerson.PersonRow drPersona in dTONPerson.Person.Rows)
        {
            eNPersona = new ENPersona();
            eNPersona.IDPerson = drPersona.IDPerson.ToString().TrimEnd();
            eNPersona.FirstName = drPersona.First_Name_Person.ToString().TrimEnd();
            eNPersona.SecondName = drPersona.Second_Name_Person.ToString().TrimEnd();
            eNPersona.LastName = drPersona.LastName_Person.ToString().TrimEnd();
            eNPersona.SecondLastName = drPersona.Second_LastName_Person.ToString().TrimEnd();
            eNPersona.CI = drPersona.CI_Person.ToString().TrimEnd();
            eNPersona.ExtCI = drPersona.Ext_CI_Person.ToString().TrimEnd();
            eNPersona.Phone = drPersona.Phone_Person.ToString().TrimEnd();
            eNPersona.Rol = drPersona.Rol_Person.ToString().TrimEnd();
            lstNPersona.Add(eNPersona);
        }
        return lstNPersona;
    }

    public ENPersona Obtener_Persona_O_Rol(string Rol)
    {
        ENPersona eNPersona = new ENPersona();
        DTONPerson dTONPerson = aDNPerson.Obtener_Persona_O_Rol(Rol);
        foreach (DTONPerson.PersonRow drPersona in dTONPerson.Person.Rows)
        {
            eNPersona = new ENPersona();
            eNPersona.IDPerson = drPersona.IDPerson.ToString().TrimEnd();
            eNPersona.FirstName = drPersona.First_Name_Person.ToString().TrimEnd();
            eNPersona.SecondName = drPersona.Second_Name_Person.ToString().TrimEnd();
            eNPersona.LastName = drPersona.LastName_Person.ToString().TrimEnd();
            eNPersona.SecondLastName = drPersona.Second_LastName_Person.ToString().TrimEnd();
            eNPersona.CI = drPersona.CI_Person.ToString().TrimEnd();
            eNPersona.ExtCI = drPersona.Ext_CI_Person.ToString().TrimEnd();
            eNPersona.Phone = drPersona.Phone_Person.ToString().TrimEnd();
            eNPersona.Rol = drPersona.Rol_Person.ToString().TrimEnd();
        }
        return eNPersona;
    }

    //public List<ENEstudiante> Obtener_Persona_O_EstudianteCompleto()
    //{
    //    ENEstudiante eNPersona = new ENEstudiante();
    //    List<ENEstudiante> lstNPersona = new List<ENEstudiante>();
    //    DTONPerson dTONPerson = aDNPerson.Obtener_Persona_O_EstudianteCompleto();
    //    foreach (DTONPerson.PersonRow drPersona in dTONPerson.Person.Rows)
    //    {
    //        eNPersona = new ENEstudiante();
    //        eNPersona.IDPerson = drPersona.IDPerson.ToString().TrimEnd();
    //        eNPersona.FirstName = drPersona.First_Name_Person.ToString().TrimEnd();
    //        eNPersona.SecondName = drPersona.Second_Name_Person.ToString().TrimEnd();
    //        eNPersona.LastName = drPersona.LastName_Person.ToString().TrimEnd();
    //        eNPersona.SecondLastName = drPersona.Second_LastName_Person.ToString().TrimEnd();
    //        eNPersona.CI = drPersona.CI_Person.ToString().TrimEnd();
    //        eNPersona.ExtCI = drPersona.Ext_CI_Person.ToString().TrimEnd();
    //        eNPersona.Phone = drPersona.Phone_Person.ToString().TrimEnd();
    //        eNPersona.Rol = drPersona.Rol_Person.ToString().TrimEnd();
    //        eNPersona.NameCareer = drPersona.Name_Career.toString
    //        lstNPersona.Add(eNPersona);
    //    }
    //    return lstNPersona;
    //}

    public ENPersona Obtener_Persona_O_Account(string Mail, string Password)
    {
        ENPersona eNPersona = new ENPersona();
        DTONPerson dTONPerson = aDNPerson.Obtener_Persona_O_Account(Mail,Password);
        foreach (DTONPerson.PersonRow drPersona in dTONPerson.Person.Rows)
        {
            eNPersona = new ENPersona();
            eNPersona.IDPerson = drPersona.IDPerson.ToString().TrimEnd();
            eNPersona.FirstName = drPersona.First_Name_Person.ToString().TrimEnd();
            eNPersona.SecondName = drPersona.Second_Name_Person.ToString().TrimEnd();
            eNPersona.LastName = drPersona.LastName_Person.ToString().TrimEnd();
            eNPersona.SecondLastName = drPersona.Second_LastName_Person.ToString().TrimEnd();
            eNPersona.CI = drPersona.CI_Person.ToString().TrimEnd();
            eNPersona.ExtCI = drPersona.Ext_CI_Person.ToString().TrimEnd();
            eNPersona.Phone = drPersona.Phone_Person.ToString().TrimEnd();
            eNPersona.Rol = drPersona.Rol_Person.ToString().TrimEnd();
        }
        return eNPersona;
    }
}