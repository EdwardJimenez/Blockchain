using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CBRolUser
/// </summary>
public class CBRolUser
{
    #region Metodos Privados
    private ADBRolUser aDBRolUser;
    #endregion
    #region Metodos Publicos
    public CBRolUser()
    {
        aDBRolUser = new ADBRolUser();
    }
    public List<EBRoluser> Obtener_RolUser_O()
    {
        EBRoluser eBRoluser = new EBRoluser();
        List<EBRoluser> lstRoluser = new List<EBRoluser>();
        DTOBRoluser dTOBRoluser = aDBRolUser.Obtener_RolUser_O();
        foreach (DTOBRoluser.BRoluserRow  drRolUser in dTOBRoluser.BRoluser.Rows)
        {
            eBRoluser = new EBRoluser();
            eBRoluser.idrolUser = drRolUser.IdrolUser.ToString();
            eBRoluser.name = drRolUser.name.ToString();
            eBRoluser.status = drRolUser.status.ToString();
            lstRoluser.Add(eBRoluser);
        }
        return lstRoluser;
    }
    #endregion
}