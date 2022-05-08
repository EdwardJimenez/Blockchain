using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SWADBlockChain;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISWLNBlockchain" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWLNBlockchain
{
    #region BUser
    [OperationContract]
    List<EBUser> Obtener_User_O();
    [OperationContract]
    EBUser btener_BUser_O_iduser(string Id_Carrera);
    [OperationContract]
    void Insertar_BUser_I_idUser_email(string Email, string password, string userNetvalle, string idrolUser,string idTitle);
    [OperationContract]
    void Actualizar_BUser_I_idUser_email(string Email, string password, string userNetvalle, string idrolUser, string idTitle);
    #endregion

    #region BTittle
    void Insertar_BTitle_I_idTitle_faculty(string faculty, string carreer, string statusTittle, DateTime dateDelivery, string statusDelivery, string idUser, string fullnameTitulado);
    #endregion
}
