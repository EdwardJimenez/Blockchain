using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISWADNetValle" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWADNetValle
{
    #region Tabla : Person
    [OperationContract]
    List<ENPersona> Obtener_Persona_O();
    [OperationContract]
    ENPersona Obtener_Persona_O_ID(string IDPerson);
    [OperationContract]
    List<ENPersona> Obtener_Persona_O_Estudiante();
    [OperationContract]
    ENPersona Obtener_Persona_O_Rol(string Rol);
    [OperationContract]
    ENPersona Obtener_Persona_O_Account(string Mail, string Password)
    #endregion
}
