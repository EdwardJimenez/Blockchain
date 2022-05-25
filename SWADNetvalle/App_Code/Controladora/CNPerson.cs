using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CBPerson
/// </summary>
public class CNPerson
{
    private ADNPerson aDNPerson;
    public CNPerson()
    {
        aDNPerson = new ADNPerson();
    }


    public ENPerson Obtener_Persona_O_Estudiante()
    {
        ENPerson eNPersona = new ENPerson();
        ENPerson NPersona = new ENPerson();
        DTONPerson dTONPerson = aDNPerson.Obtener_Persona_O_Estudiante();
        foreach (DTONPerson.PersonRow drPersona in dTONPerson.Person.Rows)
        {
            eNPersona = new ENPerson();
            eNPersona.IDPerson = drPersona.IDPerson.ToString().TrimEnd();
            eNPersona.Fullname = drPersona.Fullname.ToString();
            eNPersona.CI = drPersona.CI_Person.ToString().TrimEnd();
            eNPersona.ExtCI = drPersona.Ext_CI_Person.ToString().TrimEnd();
            eNPersona.Phone = drPersona.Phone_Person.ToString().TrimEnd();
            eNPersona.Rol = drPersona.Rol_Person.ToString().TrimEnd();
            eNPersona.IDCareer = drPersona.IDCareer.ToString().TrimEnd();
        }
        return NPersona;
    }

    public List<ENPerson> Obtener_Persona_O_EstudianteL()
    {
        ENPerson eNPersona = new ENPerson();
        List<ENPerson> lstNPersona = new List<ENPerson>();
        DTONPerson dTONPerson = aDNPerson.Obtener_Persona_O_Estudiante();
        foreach (DTONPerson.PersonRow drPersona in dTONPerson.Person.Rows)
        {
            eNPersona = new ENPerson();
            eNPersona.IDPerson = drPersona.IDPerson.ToString().TrimEnd();
            eNPersona.Fullname = drPersona.Fullname.ToString();
            eNPersona.CI = drPersona.CI_Person.ToString().TrimEnd();
            eNPersona.ExtCI = drPersona.Ext_CI_Person.ToString().TrimEnd();
            eNPersona.Phone = drPersona.Phone_Person.ToString().TrimEnd();
            eNPersona.Rol = drPersona.Rol_Person.ToString().TrimEnd();
            eNPersona.IDCareer = drPersona.IDCareer.ToString().TrimEnd();
            lstNPersona.Add(eNPersona);
        }
        return lstNPersona;
    }
    public List<ENPerson> Obtener_Persona_O_Nombre(string Fullname)
    {
        ENPerson eNPersona = new ENPerson();
        List<ENPerson> lstNPersona = new List<ENPerson>();
        DTONPerson dTONPerson = aDNPerson.Obtener_Persona_O_Nombre(Fullname);
        foreach (DTONPerson.PersonRow drPersona in dTONPerson.Person.Rows)
        {
            eNPersona = new ENPerson();
            eNPersona.IDPerson = drPersona.IDPerson.ToString().TrimEnd();
            eNPersona.Fullname = drPersona.Fullname.ToString();
            eNPersona.CI = drPersona.CI_Person.ToString().TrimEnd();
            eNPersona.ExtCI = drPersona.Ext_CI_Person.ToString().TrimEnd();
            eNPersona.Phone = drPersona.Phone_Person.ToString().TrimEnd();
            eNPersona.Rol = drPersona.Rol_Person.ToString().TrimEnd();
            eNPersona.IDCareer = drPersona.IDCareer.ToString().TrimEnd();
            lstNPersona.Add(eNPersona);
        }
        return lstNPersona;
    }
    public List<ENPerson> Obtener_Persona_O_ID(int ID)
    {
        ENPerson eNPersona = new ENPerson();
        List<ENPerson> lstNPersona = new List<ENPerson>();
        DTONPerson dTONPerson = aDNPerson.Obtener_Persona_O_ID(ID);
        foreach (DTONPerson.PersonRow drPersona in dTONPerson.Person.Rows)
        {
            eNPersona = new ENPerson();
            eNPersona.IDPerson = drPersona.IDPerson.ToString().TrimEnd();
            eNPersona.Fullname = drPersona.Fullname.ToString();
            eNPersona.CI = drPersona.CI_Person.ToString().TrimEnd();
            eNPersona.ExtCI = drPersona.Ext_CI_Person.ToString().TrimEnd();
            eNPersona.Phone = drPersona.Phone_Person.ToString().TrimEnd();
            eNPersona.Rol = drPersona.Rol_Person.ToString().TrimEnd();
            eNPersona.IDCareer = drPersona.IDCareer.ToString().TrimEnd();
            lstNPersona.Add(eNPersona);
        }
        return lstNPersona;
    }
    /*public List<ENPersona> Obtener_Persona_O()
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
    */
    /* public ENPersona Obtener_Persona_O_ID(string IDPerson)
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
    */
    /*public ENPersona Obtener_Persona_O_Rol(string Rol)
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
    }*/

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

    /*public ENPersona Obtener_Persona_O_Account(string Mail, string Password)
    {
        ENPersona eNPersona = new ENPersona();
        DTONPerson dTONPerson = aDNPerson.Obtener_Persona_O_Account(Mail, Password);
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
    }*/
}