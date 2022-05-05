using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "SWADNetValle" en el código, en svc y en el archivo de configuración a la vez.
public class SWADNetValle : ISWADNetValle
{
    public List<ENPersona> Obtener_Persona_O()
    {
        CNPerson cNPerson = new CNPerson();
        List<ENPersona> lstENPersona = new List<ENPersona>();
        lstENPersona = cNPerson.Obtener_Persona_O();
        return lstENPersona;
    }

    public ENPersona Obtener_Persona_O_Account(string Mail, string Password)
    {
        CNPerson cNPerson = new CNPerson();
        ENPersona eNPersona = new ENPersona();
        eNPersona = cNPerson.Obtener_Persona_O_Account(Mail,Password);
        return eNPersona;
    }

    public List<ENPersona> Obtener_Persona_O_Estudiante()
    {
        CNPerson cNPerson = new CNPerson();
        List<ENPersona> lstENPersona = new List<ENPersona>();
        lstENPersona = cNPerson.Obtener_Persona_O_Estudiante();
        return lstENPersona;
    }

    public ENPersona Obtener_Persona_O_ID(string IDPerson)
    {
        CNPerson cNPerson = new CNPerson();
        ENPersona eNPersona = new ENPersona();
        eNPersona = cNPerson.Obtener_Persona_O_ID(IDPerson);
        return eNPersona;
    }

    public ENPersona Obtener_Persona_O_Rol(string Rol)
    {
        CNPerson cNPerson = new CNPerson();
        ENPersona eNPersona = new ENPersona();
        eNPersona = cNPerson.Obtener_Persona_O_Rol(Rol);
        return eNPersona;
    }
}
