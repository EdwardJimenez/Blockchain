using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SWADNetValle;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISWLNBlockchain" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWLNBlockchain
{
    #region BPersona
    [OperationContract]
    ENPersona Obtener_Persona_O_Account(string Mail, string Password);
    #endregion
}
