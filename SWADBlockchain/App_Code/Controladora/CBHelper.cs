using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CBHelper
/// </summary>
public class CBHelper
{
    private ADBHelper adbHelper;

    public CBHelper()
    {
        adbHelper = new ADBHelper();
    }
    /// <summary>
    /// Obtiene todos los datos del programa en una lista
    /// </summary>
    /// <returns></returns>
    public string UltimoID_O_NombreTablaSinElCaracterI(string NombreTabla)
    {
        return adbHelper.UltimoID_O_NombreTablaSinElCaracterI(NombreTabla);
    }
    /// <summary>
    /// Obtiene todos los datos del programa en una lista
    /// </summary>
    /// <returns></returns>
    public string SiguienteID_O_NombreTablaSinElCaracterI(string NombreTabla)
    {
        return adbHelper.SiguienteID_O_NombreTablaSinElCaracterI(NombreTabla);
    }
}