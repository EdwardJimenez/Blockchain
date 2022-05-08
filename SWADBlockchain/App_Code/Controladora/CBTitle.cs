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
    #endregion
}