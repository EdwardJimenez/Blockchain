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
    void Insertar_BUser_I_idUser_email(string Id_User, string email, string password,string status ,string userNetvalle, string idrolUser, string Fullname, string Cellphone, string Ci, string description, string ciExtra);
    [OperationContract]
    void Insertar_BUser_I(string Id_User, string email, string password, string status, string userNetvalle, string idrolUser, string Fullname, string Cellphone, string Ci, string description, string ciExtra);
    [OperationContract]
    void Actualizar_BUser_I_idUser_email(string Email, string password, string userNetvalle, string idrolUser, string idTitle);
    #endregion

    #region BTittle
    [OperationContract]
    void Insertar_BTitle_I_idTitle_faculty(string faculty, string carreer, string statusTittle, DateTime dateDelivery, string statusDelivery, string idUser, string fullnameTitulado);

    [OperationContract]
    List<EBTittle> Obtener_Title_O();

    [OperationContract]
    void Actualizar_ITitle_statusTitle(string Id_Title);
    #endregion

    #region RolUser
    [OperationContract]
    List<EBRoluser> Obtener_RolUser_O();

    #endregion

    #region Helper
    [OperationContract]
    string UltimoID_O_NombreTablaSinElCaracterI(string NombreTabla);
    [OperationContract]
    string SiguienteID_O_NombreTablaSinElCaracterI(string NombreTabla);
    #endregion
}
