﻿using SWADBlockChain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "SWLNBlockchain" en el código, en svc y en el archivo de configuración a la vez.
public class SWLNBlockchain : ISWLNBlockchain
{
    #region User
    public void Actualizar_BUser_I_idUser_email(string Email, string password, string userNetvalle, string idrolUser, string idTitle)
    {
        throw new NotImplementedException();
    }

    public EBUser btener_BUser_O_iduser(string Id_Carrera)
    {
        throw new NotImplementedException();
    }

    public void Insertar_BUser_I_idUser_email(string Id_User,string Email, string password, string userNetvalle, string idrolUser, string idTitle)
    {
        CUserBlockchain cUser = new CUserBlockchain();
        cUser.Insertar_BUser_I_idUser_email(Id_User,Email, password, userNetvalle, idrolUser, idTitle);
    }

    public List<EBUser> Obtener_User_O()
    {
        throw new NotImplementedException();
    }
    #endregion
    #region Tittle

    public void Insertar_BTitle_I_idTitle_faculty(string faculty, string carreer, string statusTittle, DateTime dateDelivery, string statusDelivery, string idUser, string fullnameTitulado)
    {
        CUserBlockchain cTittle = new CUserBlockchain();
        cTittle.Insertar_BTitle_I_idTitle_faculty(faculty, carreer, statusTittle, dateDelivery, statusDelivery, idUser, fullnameTitulado);
    }

    #endregion

    #region RolUser
    public List<EBRoluser> Obtener_RolUser_O()
    {
        
        List<EBRoluser> lstEbRolUser = new List<EBRoluser>();
        CUserBlockchain cRolUser = new CUserBlockchain();
        lstEbRolUser = cRolUser.Obtener_RolUser_O();
        return lstEbRolUser;
    }
    #endregion

    #region Helper
    public string UltimoID_O_NombreTablaSinElCaracterI(string NombreTabla)
    {
        CUserBlockchain cSolicitudIntercambio = new CUserBlockchain();
        return cSolicitudIntercambio.UltimoID_O_NombreTablaSinElCaracterI(NombreTabla);
    }
    public string SiguienteID_O_NombreTablaSinElCaracterI(string NombreTabla)
    {
        CUserBlockchain cSolicitudIntercambio = new CUserBlockchain();
        return cSolicitudIntercambio.SiguienteID_O_NombreTablaSinElCaracterI(NombreTabla);
    }
    #endregion
}
