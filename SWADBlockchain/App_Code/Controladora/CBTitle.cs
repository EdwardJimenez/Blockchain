using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CBTitle
/// </summary>
public class CBTitle
{
    #region Metodos Privados
    private ADBTitle aDBTitle;
    #endregion
    #region Metodos Publicos
    public CBTitle()
    {
        aDBTitle = new ADBTitle();
    }
    public void Insertar_BTitle_I_idTitle_faculty(EBTittle bTitle)
    {
        aDBTitle.Insertar_BTitle_I_idTitle_faculty(bTitle);
    }

    public void Actualizar_ITitle_statusTitle(EBTittle ebTitle)
    {
        aDBTitle.Actualizar_ITitle_statusTitle(ebTitle);
    }

    public List<EBTittle> Obtener_Title_O()
    {
        EBTittle eBTitle = new EBTittle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        DTOBTitle dTOBTitle = aDBTitle.Obtener_Title_O();
        foreach (DTOBTitle.BTittleRow drTitle in dTOBTitle.BTittle.Rows)
        {
            eBTitle = new EBTittle();
            eBTitle.IdTittles = drTitle.IdTittle.ToString();
            eBTitle.fullNameTitulado = drTitle.fullNameT;
            eBTitle.faculty = drTitle.faculty;
            eBTitle.carreer = drTitle.carreer;
            lstTitle.Add(eBTitle);
        }
        return lstTitle;
    }

    public List<EBTittle> Obtener_Title_O_ListGraduates()
    {
        EBTittle eBTitle = new EBTittle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        DTOBTitle dTOBTitle = aDBTitle.Obtener_Title_O_ListGraduates();
        foreach (DTOBTitle.BTittleRow drTitle in dTOBTitle.BTittle.Rows)
        {
            eBTitle = new EBTittle();
            eBTitle.IdTittles = drTitle.IdTittle.ToString();
            eBTitle.fullNameTitulado = drTitle.fullNameT;
            eBTitle.faculty = drTitle.faculty;
            eBTitle.carreer = drTitle.carreer;
            lstTitle.Add(eBTitle);
        }
        return lstTitle;
    }

    public EBTittle BUser_O_Search(string name)
    {
        EBTittle eBtittle = new EBTittle();
        DTOBTitle dTOBTitle= aDBTitle.BUser_O_Search(name);
        foreach (DTOBTitle.BTittleRow user in dTOBTitle.BTittle.Rows)
        {
            eBtittle = new EBTittle();
            eBtittle.fullNameTitulado = user.fullNameT.ToString();
            eBtittle.faculty = user.faculty;
            eBtittle.carreer = user.carreer;
        }
        return eBtittle;
    }

    public List<EBTittle> BTittle_O_Faculty(string faculty)
    {
        EBTittle eBTitle = new EBTittle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        DTOBTitle dTOBTitle = aDBTitle.BTittle_O_Faculty(faculty);
        foreach (DTOBTitle.BTittleRow drTitle in dTOBTitle.BTittle.Rows)
        {
            eBTitle = new EBTittle();
            eBTitle.fullNameTitulado = drTitle.fullNameT;
            eBTitle.faculty = drTitle.faculty;
            eBTitle.carreer = drTitle.carreer;
            lstTitle.Add(eBTitle);
        }
        return lstTitle;
    }

    public List<EBTittle> BTittle_O_CARREER(string carreer)
    {
        EBTittle eBTitle = new EBTittle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        DTOBTitle dTOBTitle = aDBTitle.BTittle_O_CARREER(carreer);
        foreach (DTOBTitle.BTittleRow drTitle in dTOBTitle.BTittle.Rows)
        {
            eBTitle = new EBTittle();
            eBTitle.fullNameTitulado = drTitle.fullNameT;
            eBTitle.faculty = drTitle.faculty;
            eBTitle.carreer = drTitle.carreer;
            lstTitle.Add(eBTitle);
        }
        return lstTitle;
    }
    #endregion
}