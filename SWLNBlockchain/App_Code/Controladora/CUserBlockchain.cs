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
   

    public void Insertar_BUser_I_idUser_email(string email,string password, string userNetvalle, string idrolUser)
    {
        EBUser ebUser = new EBUser();
        try
        {
            ebUser.Email = email;
            ebUser.Password = password;
            ebUser.UserNetvalle = userNetvalle;
            ebUser.IdRolUser = idrolUser;
            asBlockchain.Insertar_BUser_I_idUser_email(ebUser);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}