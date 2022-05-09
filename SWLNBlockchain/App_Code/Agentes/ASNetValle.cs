using SWADNetValle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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

    public ENPersona Obtener_Persona_O_Account(string Mail, string Password)
    {
        ENPersona enPersona = new ENPersona();
        try
        {
            enPersona = swADNetValle.Obtener_Persona_O_Account(Mail,Password);
            return enPersona;
        }
        catch (Exception)
        {
            throw;
        }
    }
}