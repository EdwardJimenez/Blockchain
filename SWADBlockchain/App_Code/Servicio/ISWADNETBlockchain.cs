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

    [OperationContract]
    void Insertar_BUser_I(EBUser bUser);

    [OperationContract]
    EBUser Obtener_RolUser_O_Search(string email, string password);
    #endregion

    #region Tabla BTittle

    [OperationContract]
    void Insertar_BTitle_I_idTitle_faculty(EBTittle eBTittle);

    [OperationContract]
    void Insertar_BTitle(EBTittle eBTittle);


    [OperationContract]
    List<EBTittle> Search_BTitle(string name, string carreer, string faculty);


   

    
    [OperationContract]
    List<EBTittle> Obtener_Title_O();


    [OperationContract]
    List<EBTittle> Obtener_Title_1();


    [OperationContract]
    List<EBTittle> Obtener_Title_2();


    [OperationContract]
    void Actualizar_ITitle_statusTitle(EBTittle ebTitle);


    [OperationContract]
    List<EBTittle> BTittle_O_State2();

    [OperationContract]
    List<EBTittle> BTittle_O_State3();

    [OperationContract]
    List<EBTittle> BTittle_O_State4();

    [OperationContract]
    List<EBTittle> BTittle_O_State5();

    [OperationContract]
    List<EBTittle> BTittle_O_State6();

    [OperationContract]
    List<EBTittle> BTittle_O_State7();

    [OperationContract]
    void BTittle_update_statusTittle_3(EBTittle ebTitle);

    [OperationContract]
    void BTittle_update_statusTittle_4(EBTittle ebTitle);

    [OperationContract]
    void BTittle_update_statusTittle_5(EBTittle ebTitle);

    [OperationContract]
    void BTittle_update_statusTittle_6(EBTittle ebTitle);

    [OperationContract]
    void BTittle_update_statusTittle_7(EBTittle ebTitle);

    [OperationContract]
    List<EBTittle> BTittle_O_TO_Upload();
    


    [OperationContract]
    void Actualizar_ITitle_statusTitle_2(EBTittle ebTitle);

    [OperationContract]
    void Actualizar_ITitle_statusTitle_1(EBTittle ebTitle);

    [OperationContract]
    void Eliminar_ITitle_statusTitle(EBTittle ebTitle);

    [OperationContract]
    void Actualizar_ITitle(EBTittle ebTitle);

    [OperationContract]
    void Actualizar_BTittle_ConfirmarEntrega(EBTittle ebTitle);


    [OperationContract]
    List<EBTittle> Search_BTitle_Faculty_Carrer_Date(string txt);


    [OperationContract]
    List<EBTittle> Search_BTitle_Date(DateTime fechaInicio, DateTime fechaFin);

    [OperationContract]
    List<EBTittle> Obtener_Title_O_ListGraduates();

    #endregion

    #region Helper
    [OperationContract]
    string UltimoID_O_NombreTablaSinElCaracterI(string NombreTabla);
    [OperationContract]
    string SiguienteID_O_NombreTablaSinElCaracterI(string NombreTabla);
    #endregion

    #region RolUser
    [OperationContract]
    List<EBRoluser> Obtener_RolUser_O();
    #endregion

}
