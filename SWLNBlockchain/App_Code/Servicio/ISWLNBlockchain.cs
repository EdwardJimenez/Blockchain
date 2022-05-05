using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISWLNBlockchain" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWLNBlockchain
{
    [OperationContract]
    void DoWork();


    #region BPersonInsertUserNetvalle
    [OperationContract]
    List<BSolicitudCompleja> Obtener_BSolicitudCompleja_O(string Name, string Phone, DateTime registerDate, string CI, string Mail);
    #endregion
}
