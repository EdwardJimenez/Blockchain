using SWADNetValle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CAutenticarLogin
/// </summary>
public class CAutenticarLogin
{
    #region Variables Miembro
    private ASNetValle asNetValle;
    #endregion
    public CAutenticarLogin()
    {
        asNetValle = new ASNetValle();
    }

    public ENPersona Obtener_Persona_O_Account(string Mail, string Password)
    {
        ENPersona enPersona = new ENPersona();
        try
        {
            enPersona = asNetValle.Obtener_Persona_O_Account(Mail, Password);
            return enPersona;
        }
        catch (Exception)
        {
            throw;
        }
    }
}