using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "SWLNBlockchain" en el código, en svc y en el archivo de configuración a la vez.
public class SWLNBlockchain : ISWLNBlockchain
{
    public void DoWork()
    {


    }
    #region BSolicitudCompleja
    public List<BSolicitudCompleja> Obtener_ISolicitudCompleja_O()
    {
        BSolicitudIntercambio cSolicitudIntercambio = new BSolicitudIntercambio();
        List<BSolicitudCompleja> lstBSolicitudCompleja = new List<BSolicitudCompleja>();
        lstBSolicitudCompleja = cSolicitudIntercambio.Obtener_BSolicitudCompleja_O().ToList();
        return lstBSolicitudCompleja;
    }


    #endregion
    #region BSolicitudComplejaBuscarNombreEst
    public List<BSolicitudCompleja> Obtener_BSolicitudCompleja_O(string Name, string Phone, DateTime registerDate, string CI, string Mail)
    {
        BSolicitudIntercambio cSolicitudIntercambio = new CSolicitudIntercambio();
        List<ISolicitudCompleja> lstISolicitudCompleja = new List<ISolicitudCompleja>();
        lstISolicitudCompleja = cSolicitudIntercambio.Obtener_ISolicitudCompleja_O_NombreEstEx(NombreEstEx);
        return lstISolicitudCompleja;
    }
    #endregion
}
