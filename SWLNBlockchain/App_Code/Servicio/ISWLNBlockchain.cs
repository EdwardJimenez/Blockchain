﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SWADBlockChain;
using SWADNetValle;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ISWLNBlockchain" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWLNBlockchain
{
    #region BUser
    [OperationContract]
    EBUser Obtener_RolUser_O_Search(string email, string password);

    [OperationContract]
    List<EBUser> Obtener_User_O();

    [OperationContract]
    EBUser btener_BUser_O_iduser(string Id_Carrera);

    [OperationContract]
    void Insertar_BUser_I_idUser_email(string Id_User, string email, string password,string status ,string userNetvalle, string idrolUser, string Fullname, string Cellphone, string Ci, string description, string ciExtra);
    
    /*void Insertar_BUser_I_idUser_email(string Id_User, string email, string password, string status, string userNetvalle, string idrolUser, string Fullname, string Cellphone, string Ci, string description, string ciExtra);
    [OperationContract]*/
    [OperationContract]
    void Insertar_BUser_I(string Id_User, string email, string password, string status, string userNetvalle, string idrolUser, string Fullname, string Cellphone, string Ci, string description, string ciExtra);
    
    [OperationContract]
    void Actualizar_BUser_I_idUser_email(string Email, string password, string userNetvalle, string idrolUser, string idTitle);
    #endregion

    #region BTittle
    [OperationContract]
    void Insertar_BTitle_I_idTitle_faculty(string faculty, string carreer, string statusTittle, DateTime dateDelivery, string statusDelivery, string idUser, string fullnameTitulado);

    [OperationContract]
    void Insertar_BTitle(string idTittle,string faculty, string carreer, string idUser, string fullnameTitulado);

    [OperationContract]
    List<EBTittle> Search_BTitle(string name, string carreer, string faculty);

    [OperationContract]
    List<EBTittle> Obtener_Title_O();

    [OperationContract]
    List<EBTittle> Obtener_Title_1();

    [OperationContract]
    List<EBTittle> Obtener_Title_2();

    [OperationContract]
    void Actualizar_ITitle_statusTitle(string Id_Title);


    [OperationContract]
    void BTittle_update_statusTittle_3(string Id_Title);

    [OperationContract]
    void BTittle_update_statusTittle_4(string Id_Title);

    [OperationContract]
    void BTittle_update_statusTittle_5(string Id_Title);

    [OperationContract]
    void BTittle_update_statusTittle_6(string Id_Title);

    [OperationContract]
    void BTittle_update_statusTittle_7(string Id_Title);

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
    List<EBTittle> BTittle_O_TO_Upload();


    [OperationContract]
    void Actualizar_ITitle_statusTitle_2(string Id_Title);

    [OperationContract]
    void Actualizar_ITitle_statusTitle_1(string Id_Title);

    [OperationContract]
    void Eliminar_ITitle_statusTitle(string Id_Title);

    [OperationContract]
    void Actualizar_ITitle(string Id_Title, string carreer, string faculty, string fullName);

    [OperationContract]
    void Actualizar_BTittle_ConfirmarEntrega(string fullName, DateTime fecha, string modo);
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

    #region NUser
    [OperationContract]
    ENPerson Obtener_Persona_O_Estudiante();

    [OperationContract]
    List<ENPerson> Obtener_Persona_O_EstudianteL();

    [OperationContract]
    List<ENPerson> Obtener_Persona_O_Nombre(string Fullname);


    [OperationContract]
    List<ENPerson> Obtener_Persona_O();
    #endregion
    #region NCareerUniversity
    [OperationContract]
    ENCareer Obtener_Carrerra_O_ID_Pedro(string id);
    #endregion
    #region IUserCareerCompleja
    [OperationContract]
    List<IUserCareerCompleja> U_Obtener_UserCareerComplejas_O_Est();
    [OperationContract]
    List<IUserCareerCompleja> U_Obtener_UserCareerComplejas_O_Person();

    [OperationContract]
    List<IUserCareerCompleja> U_Obtener_UserCareerComplejas_O_Est_Bus(string Fullname);

    [OperationContract]
    List<IUserCareerCompleja> U_Obtener_UserCareerComplejas_O_Est_ID(int ID);
    #endregion

}