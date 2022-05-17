using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SWADNetValle;
/// <summary>
/// Descripción breve de ASNetValle
/// </summary>
public class ASNetValle
{
    private SWADNetValleClient swADNetValle;

    public ASNetValle()
    {
        swADNetValle = new SWADNetValleClient();
    }

    public ENCareer Obtener_Carrerra_O_ID_Pedro(string id)
    {
        ENCareer eNCareer = new ENCareer();
        try
        {
            eNCareer = swADNetValle.Obtener_Carrerra_O_ID_Pedro(id);
            return eNCareer;
        }
        catch (Exception)
        {

            throw;
        }
    }

    public ENPerson Obtener_Persona_O_Estudiante()
    {
        ENPerson eNPerson = new ENPerson();
        try
        {
            eNPerson = swADNetValle.Obtener_Persona_O_Estudiante();
            return eNPerson;
        }
        catch (Exception)
        {

            throw;
        }
    }
    public List<ENPerson> Obtener_Persona_O_EstudianteL()
    {
        List<ENPerson> lsteNPerson = new List<ENPerson>();
        try
        {
            lsteNPerson = swADNetValle.Obtener_Persona_O_EstudianteL().ToList();
            return lsteNPerson;
        }
        catch (Exception)
        {

            throw;
        }
    }
}