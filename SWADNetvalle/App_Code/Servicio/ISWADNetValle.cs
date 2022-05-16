﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISWADNetValle" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWADNetValle
{


    [OperationContract]
    ENCareer Obtener_Carrerra_O_ID_Pedro(string id);

    [OperationContract]

    List<ENPerson> Obtener_Persona_O_EstudianteL(string id);

    [OperationContract]
    ENPerson Obtener_Persona_O_Estudiante(string Rol);

}
