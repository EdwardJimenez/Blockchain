using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CBUser
/// </summary>
public class CBUser
{
    #region Metodos Privados
    private ADBUser adBUser;
    #endregion
    #region Metodos Publicos
    public CBUser()
    {
        adBUser = new ADBUser();
    }
    
    public void Insertar_BUser_I_idUser_email(EBUser eBUser)
    {
        //adBUser.Insertar_BUser_I_idUser_email(eBUser);
    }
    public void Insertar_BUser_I(EBUser bUser)
    {
        adBUser.Insertar_BUser_I(bUser);
    }
    //public void Actualizar_ICarrera_A_CarreraID_NombreCarrera(EICarrera eICarrera)
    //{
    //    adICarrera.Actualizar_ICarrera_A_CarreraID_NombreCarrera(eICarrera);
    //}

    public EBUser Obtener_RolUser_O_Search(string email, string password)
    {
        EBUser eBuser = new EBUser();
        DTOBUser dTOBUser = adBUser.Obtener_RolUser_O_Search(email, password);
        foreach (DTOBUser.BUserRow user in dTOBUser.BUser.Rows)
        {
            eBuser = new EBUser();
            eBuser.IdRolUser = user.IdrolUser.ToString();
        }
        return eBuser;
    }
    #endregion
}