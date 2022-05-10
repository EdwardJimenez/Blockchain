using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CBTitle
/// </summary>
public class CBTitle
{
    #region Metodos Privados
    private ADBTitle adBTitle;
    #endregion
    public CBTitle()
    {
        adBTitle = new ADBTitle();
    }
    public void Actualizar_BTitle_A_statusTittle(EBTittle eITitle)
        {
        adBTitle.Actualizar_BTitle_A_statusTittle(eITitle);
        }

    public List<EBTittle> Obtener_BTitle_O_statusTitle()
    {
        EBTittle eBTitle = new EBTittle();
        List<EBTittle> lstBTitle = new List<EBTittle>();
        DTOBTitle dtoBTitle = adBTitle.Obtener_BTitle_O_statusTitle();
        foreach (DTOBTitle.TitleRow drBTitle in dtoBTitle.Title.Rows)
        {
            eBTitle = new EBTittle();
            eBTitle.IdTittles = drBTitle.IdTittles.ToString();
            eBTitle.faculty = drBTitle.faculty.ToString();
            eBTitle.carreer = drBTitle.carreer.ToString();
            eBTitle.fullName = drBTitle.fullName.ToString();
            lstBTitle.Add(eBTitle);
        }
        return lstBTitle;
    }

}