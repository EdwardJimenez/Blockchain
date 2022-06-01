using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SWADBlockChain;
/// <summary>
/// Descripción breve de CUserBlockchain
/// </summary>
public class CUserBlockchain
{
    #region Variables miembro
    private ASBlockchain asBlockchain;
    #endregion
   
    public CUserBlockchain()
    {
        asBlockchain = new ASBlockchain();
    }
    #region BUser

    public EBUser Obtener_RolUser_O_Search(string email, string password)
    {
        EBUser eBUser = new EBUser();
        try
        {
            eBUser = asBlockchain.Obtener_RolUser_O_Search(email, password);
            return eBUser;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Insertar_BUser_I_idUser_email(string Id_User,string email,string password,string status, string userNetvalle, string idrolUser, string Fullname, string Cellphone, string Ci , string description, string ciExtra)
    {
        EBUser ebUser = new EBUser();
        try
        {
            ebUser.IdUser = Id_User;
            ebUser.Email = email;
            ebUser.Password = password;
            ebUser.status = status;
            ebUser.UserNetvalle = userNetvalle;
            ebUser.IdRolUser = idrolUser;
            ebUser.Fullname = Fullname;
            ebUser.Cellphone = Cellphone;
            ebUser.CI = Ci;
            ebUser.Descripcion = description;
            ebUser.CIExtra = ciExtra; 
            asBlockchain.Insertar_BUser_I_idUser_email(ebUser);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Insertar_BUser_I(string Id_User, string email, string password, string status, string userNetvalle, string idrolUser, string Fullname, string Cellphone, string Ci, string description, string ciExtra)
    {
        EBUser ebUser = new EBUser();
        try
        {
            ebUser.IdUser = Id_User;
            ebUser.Email = email;
            ebUser.Password = password;
            ebUser.status = status;
            ebUser.UserNetvalle = userNetvalle;
            ebUser.IdRolUser = idrolUser;
            ebUser.Fullname = Fullname;
            ebUser.Cellphone = Cellphone;
            ebUser.CI = Ci;
            ebUser.Descripcion = description;
            ebUser.CIExtra = ciExtra;
            asBlockchain.Insertar_BUser_I(ebUser);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region BTitle
    public void BTittle_update_statusTittle_7(string Id_Title)
    {
        EBTittle ebTitle = new EBTittle();
        try
        {
            ebTitle.IdTittles = Id_Title;
            asBlockchain.BTittle_update_statusTittle_7(ebTitle);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void BTittle_update_statusTittle_6(string Id_Title)
    {
        EBTittle ebTitle = new EBTittle();
        try
        {
            ebTitle.IdTittles = Id_Title;
            asBlockchain.BTittle_update_statusTittle_6(ebTitle);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EBTittle> BTittle_O_State7()
    {
        List<EBTittle> eBTitle = new List<EBTittle>();
        try
        {
            eBTitle = asBlockchain.BTittle_O_State7().ToList();
            return eBTitle;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EBTittle> BTittle_O_State6()
    {
        List<EBTittle> eBTitle = new List<EBTittle>();
        try
        {
            eBTitle = asBlockchain.BTittle_O_State6().ToList();
            return eBTitle;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EBTittle> BTittle_O_State5()
    {
        List<EBTittle> eBTitle = new List<EBTittle>();
        try
        {
            eBTitle = asBlockchain.BTittle_O_State5().ToList();
            return eBTitle;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EBTittle> Obtener_Title_O()
    {
        List<EBTittle> eBTitle = new List<EBTittle>();
        try
        {
            eBTitle = asBlockchain.Obtener_Title_O().ToList();
            return eBTitle;
        }
        catch (Exception)
        {
            throw;
        }
    }
    

    public void Actualizar_ITitle_statusTitle(string Id_Title)
    {
        EBTittle ebTitle = new EBTittle();
        try
        {
            ebTitle.IdTittles = Id_Title;
            asBlockchain.Actualizar_ITitle_statusTitle(ebTitle);
        }
        catch (Exception)
        {
            throw;
        }
    }


    public void Insertar_BTitle_I_idTitle_faculty(string faculty, string carreer, string statusTittle, DateTime dateDelivery, string statusDelivery, string idUser, string fullnameTitulado)
    {
        EBTittle ebTittle = new EBTittle();
        try
        {
            ebTittle.faculty = faculty;
            ebTittle.carreer = carreer;
            ebTittle.statusTitle = statusTittle;
            ebTittle.dateDelivery = dateDelivery;
            ebTittle.statusDelivery = statusDelivery;
            ebTittle.idUser = idUser;
            ebTittle.fullNameTitulado = fullnameTitulado;


            asBlockchain.Insertar_BTitle_I_idTitle_faculty(ebTittle);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region RolUser
    public List<EBRoluser> Obtener_RolUser_O()
    {
        List<EBRoluser>eBRolUsers = new List<EBRoluser>();
        try
        {
            eBRolUsers = asBlockchain.Obtener_RolUser_O().ToList();
            return eBRolUsers;
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region Helper
    public string UltimoID_O_NombreTablaSinElCaracterI(string NombreTabla)
    {
        try
        {
            return asBlockchain.UltimoID_O_NombreTablaSinElCaracterI(NombreTabla);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public string SiguienteID_O_NombreTablaSinElCaracterI(string NombreTabla)
    {
        try
        {
            return asBlockchain.SiguienteID_O_NombreTablaSinElCaracterI(NombreTabla);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion


}