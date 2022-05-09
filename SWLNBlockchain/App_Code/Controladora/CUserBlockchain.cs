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