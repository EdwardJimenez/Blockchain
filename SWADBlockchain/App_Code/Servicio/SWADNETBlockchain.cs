using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "SWADNETBlockchain" en el código, en svc y en el archivo de configuración a la vez.
public class SWADNETBlockchain : ISWADNETBlockchain
{
    public void Actualizar_BUser_I_idUser_email(EBUser eBUser)
    {
        throw new NotImplementedException();
    }

    public void Insertar_BUser_I_idUser_email(EBUser eBUser)
    {
        CBUser cBUser = new CBUser();
        cBUser.Insertar_BUser_I_idUser_email(eBUser);
    }

    public EBUser Obtener_BUser_O_iduser(string Id_User)
    {
        throw new NotImplementedException();
    }

    public List<EBUser> Obtener_User_O()
    {
        throw new NotImplementedException();
    }
}
