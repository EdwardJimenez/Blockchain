﻿using System;
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
    public void BTittle_update_statusTittle_6(EBTittle ebTitle)
    {
        aDBTitle.BTittle_update_statusTittle_6(ebTitle);
    }
    public void BTittle_update_statusTittle_7(EBTittle ebTitle)
    {
        aDBTitle.BTittle_update_statusTittle_7(ebTitle);
    }
    
    #endregion
}