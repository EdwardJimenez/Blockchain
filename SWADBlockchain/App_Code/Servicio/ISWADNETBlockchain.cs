using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISWADNETBlockchain" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWADNETBlockchain
{
    [OperationContract]
    List<EBTittle> Obtener_BTitle_O_statusTitle();

    [OperationContract]
    void Actualizar_BTitle_A_statusTittle(EBTittle eBTittle);
}
