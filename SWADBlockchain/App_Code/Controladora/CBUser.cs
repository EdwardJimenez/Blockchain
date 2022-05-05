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
    //public List<EICarrera> Obtener_ICarrera_O()
    //{
    //    EICarrera eICarrera = new EICarrera();
    //    List<EICarrera> lstICarrera = new List<EICarrera>();
    //    DTOICarrera dtoICarrera = adICarrera.Obtener_ICarrera_O();
    //    foreach (DTOICarrera.ICarreraRow drICarrera in dtoICarrera.ICarrera.Rows)
    //    {
    //        eICarrera = new EICarrera();
    //        eICarrera.Id_Carrera = drICarrera.CarreraID.ToString();
    //        eICarrera.NombreCarrera = drICarrera.NombreCarrera.ToString();
    //        lstICarrera.Add(eICarrera);
    //    }
    //    return lstICarrera;
    //}
    //public EICarrera Obtener_ICarrera_O_CarreraID(string Id_Carrera)
    //{
    //    EICarrera eICarrera = new EICarrera();
    //    DTOICarrera dtoICarrera = adICarrera.Obtener_ICarrera_O_CarreraID(Id_Carrera);
    //    foreach (DTOICarrera.ICarreraRow drICarrera in dtoICarrera.ICarrera.Rows)
    //    {
    //        eICarrera = new EICarrera();
    //        eICarrera.Id_Carrera = drICarrera.CarreraID.ToString().TrimEnd();
    //        eICarrera.NombreCarrera = drICarrera.NombreCarrera.ToString().TrimEnd();
    //    }
    //    return eICarrera;
    //}

    public void Insertar_BUser_I_idUser_email(EBUser eBUser)
    {
        adBUser.Insertar_BUser_I_idUser_email(eBUser);
    }
    //public void Actualizar_ICarrera_A_CarreraID_NombreCarrera(EICarrera eICarrera)
    //{
    //    adICarrera.Actualizar_ICarrera_A_CarreraID_NombreCarrera(eICarrera);
    //}
    #endregion
}