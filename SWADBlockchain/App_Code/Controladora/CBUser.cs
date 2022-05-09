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
    #endregion
}