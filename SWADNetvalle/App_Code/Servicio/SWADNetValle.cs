using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "SWADNetValle" en el código, en svc y en el archivo de configuración a la vez.
public class SWADNetValle : ISWADNetValle
{
    public ENCareer Obtener_Carrerra_O_ID_Pedro(string id)
    {
        CNCareer cNCareer = new CNCareer();
        ENCareer eNCareer = new ENCareer();
        eNCareer = cNCareer.Obtener_Carrerra_O_ID_Pedro(id);
        return eNCareer;
    }

    public ENPerson Obtener_Persona_O_Estudiante()
    {
        CNPerson cNPerson = new CNPerson();
        ENPerson eNPersona = new ENPerson();
        eNPersona = cNPerson.Obtener_Persona_O_Estudiante();
        return eNPersona;
    }

    public List<ENPerson> Obtener_Persona_O_EstudianteL()
    {
        CNPerson cNPerson = new CNPerson();
        List<ENPerson> lsteNPersona = new List<ENPerson>();
        lsteNPersona = cNPerson.Obtener_Persona_O_EstudianteL();
        return lsteNPersona;
    }
    public List<ENPerson> Obtener_Persona_O()
    {
        CNPerson cNPerson = new CNPerson();
        List<ENPerson> lsteNPersona = new List<ENPerson>();
        lsteNPersona = cNPerson.Obtener_Persona_O();
        return lsteNPersona;
    }
    public List<ENPerson> Obtener_Persona_O_Nombre(string Fullname)
    {
        CNPerson cNPerson = new CNPerson();
        List<ENPerson> lsteNPersona = new List<ENPerson>();
        lsteNPersona = cNPerson.Obtener_Persona_O_Nombre(Fullname);
        return lsteNPersona;
    }


    public List<ENPerson> Obtener_Persona_O_L()
    {
        CNPerson cNPerson = new CNPerson();
        List<ENPerson> lsteNPersona = new List<ENPerson>();
        lsteNPersona = cNPerson.Obtener_Persona_O_L();
        return lsteNPersona;
    }

    public List<ENPerson> Obtener_Persona_O_ID(int ID)
    {
        CNPerson cNPerson = new CNPerson();
        List<ENPerson> lsteNPersona = new List<ENPerson>();
        lsteNPersona = cNPerson.Obtener_Persona_O_ID(ID);
        return lsteNPersona;
    }
    
}
