using SWADNetValle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "SWLNBlockchain" en el código, en svc y en el archivo de configuración a la vez.
public class SWLNBlockchain : ISWLNBlockchain
{
    public ENPersona Obtener_Persona_O_Account(string Mail, string Password)
    {
        ENPersona ePersona = new ENPersona();
        CAutenticarLogin cAuntenticarLogin = new CAutenticarLogin();
        ePersona = cAuntenticarLogin.Obtener_Persona_O_Account(Mail, Password);
        return ePersona;
    }
}
