using System;
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
    public void Insertar_BUser_I(EBUser bUser)
    {
        CBUser cBUser = new CBUser();
        cBUser.Insertar_BUser_I(bUser);
    }
    public EBUser Obtener_BUser_O_iduser(string Id_User)
    {
        throw new NotImplementedException();
    }

    public List<EBUser> Obtener_User_O()
    {
        throw new NotImplementedException();
    }

    public EBUser Obtener_RolUser_O_Search(string email, string password)
    {
        CBUser cBUser = new CBUser();
        EBUser eBuser = new EBUser();
        eBuser = cBUser.Obtener_RolUser_O_Search(email, password);
        return eBuser;
    }
    #endregion

    #region Tabla BTittle
    public void Insertar_BTitle_I_idTitle_faculty(EBTittle eBTittle)
    {
        CBTitle cBTittle = new CBTitle();
        cBTittle.Insertar_BTitle_I_idTitle_faculty(eBTittle);
    }

    public void Insertar_BTitle(EBTittle eBTittle)
    {
        CBTitle cBTittle = new CBTitle();
        cBTittle.Insertar_BTitle(eBTittle);
    }

    public void Actualizar_ITitle_statusTitle(EBTittle ebTitle)
    {
        CBTitle cBTitle = new CBTitle();
        cBTitle.Actualizar_ITitle_statusTitle(ebTitle);
    }
    public void BTittle_update_statusTittle_7(EBTittle ebTitle)
    {
        CBTitle cBTitle = new CBTitle();
        cBTitle.BTittle_update_statusTittle_7(ebTitle);
    }
    public void BTittle_update_statusTittle_6(EBTittle ebTitle)
    {
        CBTitle cBTitle = new CBTitle();
        cBTitle.BTittle_update_statusTittle_6(ebTitle);
    }
    public void BTittle_update_statusTittle_5(EBTittle ebTitle)
    {
        CBTitle cBTitle = new CBTitle();
        cBTitle.BTittle_update_statusTittle_5(ebTitle);
    }
    public void BTittle_update_statusTittle_4(EBTittle ebTitle)
    {
        CBTitle cBTitle = new CBTitle();
        cBTitle.BTittle_update_statusTittle_4(ebTitle);
    }
    public void BTittle_update_statusTittle_3(EBTittle ebTitle)
    {
        CBTitle cBTitle = new CBTitle();
        cBTitle.BTittle_update_statusTittle_3(ebTitle);
    }
    public void Eliminar_ITitle_statusTitle(EBTittle ebTitle)
    {
        CBTitle cBTitle = new CBTitle();
        cBTitle.Eliminar_ITitle_statusTitle(ebTitle);
    }

    public void Actualizar_ITitle(EBTittle ebTitle)
    {
        CBTitle cBTitle = new CBTitle();
        cBTitle.Actualizar_ITitle(ebTitle);
    }

    public void Actualizar_BTittle_ConfirmarEntrega(EBTittle ebTitle)
    {
        CBTitle cBTitle = new CBTitle();
        cBTitle.Actualizar_BTittle_ConfirmarEntrega(ebTitle);
    }

    public List<EBTittle> Obtener_Title_O()
    {
        CBTitle cBTitle = new CBTitle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        lstTitle = cBTitle.Obtener_Title_O();
        return lstTitle;
    }
    public List<EBTittle> BTittle_O_State2()
    {
        CBTitle cBTitle = new CBTitle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        lstTitle = cBTitle.BTittle_O_State2();
        return lstTitle;
    }
    public List<EBTittle> BTittle_O_State3()
    {
        CBTitle cBTitle = new CBTitle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        lstTitle = cBTitle.BTittle_O_State3();
        return lstTitle;
    }
    public List<EBTittle> BTittle_O_State4()
    {
        CBTitle cBTitle = new CBTitle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        lstTitle = cBTitle.BTittle_O_State4();
        return lstTitle;
    }
    public List<EBTittle> BTittle_O_State5()
    {
        CBTitle cBTitle = new CBTitle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        lstTitle = cBTitle.BTittle_O_State5();
        return lstTitle;
    }
    public List<EBTittle> BTittle_O_State6()
    {
        CBTitle cBTitle = new CBTitle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        lstTitle = cBTitle.BTittle_O_State6();
        return lstTitle;
    }
    public List<EBTittle> BTittle_O_State7()
    {
        CBTitle cBTitle = new CBTitle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        lstTitle = cBTitle.BTittle_O_State7();
        return lstTitle; 
    }
    public List<EBTittle> BTittle_O_TO_Upload()
    {
        CBTitle cBTitle = new CBTitle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        lstTitle = cBTitle.BTittle_O_TO_Upload();
        return lstTitle;
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
