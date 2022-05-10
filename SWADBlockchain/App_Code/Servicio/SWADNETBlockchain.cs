using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "SWADNETBlockchain" en el código, en svc y en el archivo de configuración a la vez.
public class SWADNETBlockchain : ISWADNETBlockchain
{
    public List<EBTittle> Obtener_BTitle_O_statusTitle()
    {
        CBTitle cBTitles= new CBTitle();
        List<EBTittle> lstEBtitle = new List<EBTittle>();
        lstEBtitle = cBTitles.Obtener_BTitle_O_statusTitle();
        return lstEBtitle;
    }
    public void Actualizar_BTitle_A_statusTittle(EBTittle eBTitle)
    {
        CBTitle cBTitles = new CBTitle();
        cBTitles.Actualizar_BTitle_A_statusTittle(eBTitle);
    }
}
