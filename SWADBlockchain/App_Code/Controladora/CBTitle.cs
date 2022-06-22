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
    public void Insertar_BTitle(EBTittle bTitle)
    {
        aDBTitle.Insertar_BTitle(bTitle);
    }

    public void Actualizar_ITitle_statusTitle(EBTittle ebTitle)
    {
        aDBTitle.Actualizar_ITitle_statusTitle(ebTitle);
    }
    public void Actualizar_ITitle_statusTitle_2(EBTittle ebTitle)
    {
        aDBTitle.Actualizar_ITitle_statusTitle_2(ebTitle);
    }

    public void Actualizar_ITitle_statusTitle_1(EBTittle ebTitle)
    {
        aDBTitle.Actualizar_ITitle_statusTitle_1(ebTitle);
    }

    public void Eliminar_ITitle_statusTitle(EBTittle ebTitle)
    {
        aDBTitle.Eliminar_ITitle_statusTitle(ebTitle);
    }

    public void Actualizar_ITitle(EBTittle ebTitle)
    {
        aDBTitle.Actualizar_ITitle(ebTitle);
    }

    public List<EBTittle> Search_BTitle(string name, string carreer, string faculty)
    {
        EBTittle eBTitle = new EBTittle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        DTOBTitle dTOBTitle = aDBTitle.Search_BTitle(name,carreer,faculty);
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


    public void Actualizar_BTittle_ConfirmarEntrega(EBTittle ebTitle)
    {
        aDBTitle.Actualizar_BTittle_ConfirmarEntrega(ebTitle);
    }
    public List<EBTittle> BTittle_O_State2()
    {
        EBTittle eBTitle = new EBTittle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        DTOBTitle dTOBTitle = aDBTitle.BTittle_O_State2();
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
    public List<EBTittle> BTittle_O_State3()
    {
        EBTittle eBTitle = new EBTittle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        DTOBTitle dTOBTitle = aDBTitle.BTittle_O_State3();
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
    public List<EBTittle> BTittle_O_State4()
    {
        EBTittle eBTitle = new EBTittle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        DTOBTitle dTOBTitle = aDBTitle.BTittle_O_State4();
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
    public List<EBTittle> BTittle_O_State5()
    {
        EBTittle eBTitle = new EBTittle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        DTOBTitle dTOBTitle = aDBTitle.BTittle_O_State5();
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
    public List<EBTittle> BTittle_O_State6()
    {
        EBTittle eBTitle = new EBTittle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        DTOBTitle dTOBTitle = aDBTitle.BTittle_O_State6();
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
    public List<EBTittle> BTittle_O_State7()
    {
        EBTittle eBTitle = new EBTittle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        DTOBTitle dTOBTitle = aDBTitle.BTittle_O_State7();
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
    public void BTittle_update_statusTittle_3(EBTittle ebTitle)
    {
        aDBTitle.BTittle_update_statusTittle_3(ebTitle);
    }
    public void BTittle_update_statusTittle_4(EBTittle ebTitle)
    {
        aDBTitle.BTittle_update_statusTittle_4(ebTitle);
    }
    public void BTittle_update_statusTittle_5(EBTittle ebTitle)
    {
        aDBTitle.BTittle_update_statusTittle_5(ebTitle);
    }
    public void BTittle_update_statusTittle_6(EBTittle ebTitle)
    {
        aDBTitle.BTittle_update_statusTittle_6(ebTitle);
    }
    public void BTittle_update_statusTittle_7(EBTittle ebTitle)
    {
        aDBTitle.BTittle_update_statusTittle_7(ebTitle);
    }
    
    public List<EBTittle> BTittle_O_TO_Upload()
        {
            EBTittle eBTitle = new EBTittle();
            List<EBTittle> lstTitle = new List<EBTittle>();
            DTOBTitle dTOBTitle = aDBTitle.BTittle_O_TO_Upload();
            foreach (DTOBTitle.BTittleRow drTitle in dTOBTitle.BTittle.Rows)
            {
                eBTitle = new EBTittle();
                eBTitle.IdTittles = drTitle.IdTittle.ToString();
                eBTitle.fullNameTitulado = drTitle.fullNameT;
                eBTitle.faculty = drTitle.faculty;
                eBTitle.carreer = drTitle.carreer;
                eBTitle.dateDelivery = drTitle.dateDelivery;
            lstTitle.Add(eBTitle);
            }
            return lstTitle;
        }
    public List<EBTittle> Obtener_Title_2()
    {
        EBTittle eBTitle = new EBTittle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        DTOBTitle dTOBTitle = aDBTitle.Obtener_Title_2();
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
    public List<EBTittle> Obtener_Title_1()
    {
        EBTittle eBTitle = new EBTittle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        DTOBTitle dTOBTitle = aDBTitle.Obtener_Title_1();
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


    public List<EBTittle> Search_BTitle_Faculty_Carrer_Date(string txt)
    {
        EBTittle eBTitle = new EBTittle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        DTOBTitle dTOBTitle = aDBTitle.Search_BTitle_Faculty_Carrer_Date(txt);
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

    public List<EBTittle> Search_BTitle_Date(DateTime fechaInicio, DateTime fechaFin)
    {
        EBTittle eBTitle = new EBTittle();
        List<EBTittle> lstTitle = new List<EBTittle>();
        DTOBTitle dTOBTitle = aDBTitle.Search_BTitle_Date(fechaInicio, fechaFin);
        foreach (DTOBTitle.BTittleRow drTitle in dTOBTitle.BTittle.Rows)
        {
            eBTitle = new EBTittle();
            eBTitle.IdTittles = drTitle.IdTittle.ToString();
            eBTitle.fullNameTitulado = drTitle.fullNameT;
            eBTitle.faculty = drTitle.faculty;
            eBTitle.carreer = drTitle.carreer;
            eBTitle.registerDate = drTitle.registerDate;
            lstTitle.Add(eBTitle);
        }
        return lstTitle;
    }

    #endregion
}