﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "SWADNETBlockchain" en el código, en svc y en el archivo de configuración a la vez.
public class SWADNETBlockchain : ISWADNETBlockchain
{
    #region Tabla BUser
    public void Actualizar_BUser_I_idUser_email(EBUser eBUser)
    {
        throw new NotImplementedException();
    }

    public void Insertar_BUser_I_idUser_email(EBUser eBUser)
    {
        CBUser cBUser = new CBUser();
        cBUser.Insertar_BUser_I_idUser_email(eBUser);
    }

    public EBUser Obtener_BUser_O_iduser(string Id_User)
    {
        throw new NotImplementedException();
    }

    public List<EBUser> Obtener_User_O()
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Tabla BTittle
    public void Insertar_BTitle_I_idTitle_faculty(EBTittle eBTittle)
    {
        CBTitle cBTittle = new CBTitle();
        cBTittle.Insertar_BTitle_I_idTitle_faculty(eBTittle);
    }


    #endregion

    #region Helper
    public string UltimoID_O_NombreTablaSinElCaracterI(string NombreTabla)
    {
        CBHelper cBHelper = new CBHelper();
        return cBHelper.UltimoID_O_NombreTablaSinElCaracterI(NombreTabla);
    }

    public string SiguienteID_O_NombreTablaSinElCaracterI(string NombreTabla)
    {
        CBHelper cBHelper = new CBHelper();
        return cBHelper.SiguienteID_O_NombreTablaSinElCaracterI(NombreTabla);
    }
    #endregion

    #region roluser
    public List<EBRoluser> Obtener_RolUser_O()
    {
        CBRolUser cBRolUser = new CBRolUser();
        List<EBRoluser> lstRolUser = new List<EBRoluser>();
        lstRolUser = cBRolUser.Obtener_RolUser_O();
        return lstRolUser;
    }
    #endregion
}
