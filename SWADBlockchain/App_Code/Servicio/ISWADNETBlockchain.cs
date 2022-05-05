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
    
    #region Tabla : BUser
    [OperationContract]
    List<EBUser> Obtener_User_O();
    [OperationContract]
    EBUser Obtener_BUser_O_iduser(string Id_User);
    [OperationContract]
    void Insertar_BUser_I_idUser_email(EBUser eBUser);
    [OperationContract]
    void Actualizar_BUser_I_idUser_email(EBUser eBUser);
    #endregion
}
