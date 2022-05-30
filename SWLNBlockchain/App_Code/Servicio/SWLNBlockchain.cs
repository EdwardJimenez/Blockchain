using SWADBlockChain;
using SWADNetValle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "SWLNBlockchain" en el código, en svc y en el archivo de configuración a la vez.
public class SWLNBlockchain : ISWLNBlockchain
{
    #region User
    public void Actualizar_BUser_I_idUser_email(string Email, string password, string userNetvalle, string idrolUser, string idTitle)
    {
        throw new NotImplementedException();
    }

    public EBUser btener_BUser_O_iduser(string Id_Carrera)
    {
        throw new NotImplementedException();
    }

    public void Insertar_BUser_I_idUser_email(string Id_User, string email, string password,string status ,string userNetvalle, string idrolUser, string Fullname, string Cellphone, string Ci, string description, string ciExtra)
    {
        CUserBlockchain cUser = new CUserBlockchain();
        cUser.Insertar_BUser_I_idUser_email(Id_User,email, password,status ,userNetvalle, idrolUser, Fullname,Cellphone, Ci, description,ciExtra);
    }
    public void Insertar_BUser_I(string Id_User, string email, string password, string status, string userNetvalle, string idrolUser, string Fullname, string Cellphone, string Ci, string description, string ciExtra)
    {
        CUserBlockchain cUser = new CUserBlockchain();
        cUser.Insertar_BUser_I(Id_User,email,password,status,userNetvalle,idrolUser,Fullname,Cellphone,Ci,description,ciExtra);
    }
    public List<EBUser> Obtener_User_O()
    {
        throw new NotImplementedException();
    }
    #endregion
    #region Tittle

    public List<EBTittle> Obtener_Title_O()
    {

        List<EBTittle> eBTitle = new List<EBTittle>();
        CUserBlockchain cUserBlockchain = new CUserBlockchain();
        eBTitle = cUserBlockchain.Obtener_Title_O().ToList();
        return eBTitle;
    }

    public List<EBTittle> Obtener_Title_1()
    {

        List<EBTittle> eBTitle = new List<EBTittle>();
        CUserBlockchain cUserBlockchain = new CUserBlockchain();
        eBTitle = cUserBlockchain.Obtener_Title_1().ToList();
        return eBTitle;
    }

    public List<EBTittle> Obtener_Title_2()
    {

        List<EBTittle> eBTitle = new List<EBTittle>();
        CUserBlockchain cUserBlockchain = new CUserBlockchain();
        eBTitle = cUserBlockchain.Obtener_Title_2().ToList();
        return eBTitle;
    }
    public void Actualizar_ITitle_statusTitle(string Id_Title)
    {
        CUserBlockchain cUserBlockchain = new CUserBlockchain();
        cUserBlockchain.Actualizar_ITitle_statusTitle(Id_Title);
    }

    public void Actualizar_ITitle_statusTitle_2(string Id_Title)
    {
        CUserBlockchain cUserBlockchain = new CUserBlockchain();
        cUserBlockchain.Actualizar_ITitle_statusTitle_2(Id_Title);
    }

    public void Actualizar_ITitle_statusTitle_1(string Id_Title)
    {
        CUserBlockchain cUserBlockchain = new CUserBlockchain();
        cUserBlockchain.Actualizar_ITitle_statusTitle_1(Id_Title);
    }

    public void Eliminar_ITitle_statusTitle(string Id_Title)
    {
        CUserBlockchain cUserBlockchain = new CUserBlockchain();
        cUserBlockchain.Eliminar_ITitle_statusTitle(Id_Title);
    }

    public void Actualizar_ITitle(string Id_Title, string carreer, string faculty, string fullName)
    {
        CUserBlockchain cUserBlockchain = new CUserBlockchain();
        cUserBlockchain.Actualizar_ITitle(Id_Title,carreer,faculty,fullName);
    }

    public void Insertar_BTitle_I_idTitle_faculty(string faculty, string carreer, string statusTittle, DateTime dateDelivery, string statusDelivery, string idUser, string fullnameTitulado)
    {
        CUserBlockchain cTittle = new CUserBlockchain();
        cTittle.Insertar_BTitle_I_idTitle_faculty(faculty, carreer, statusTittle, dateDelivery, statusDelivery, idUser, fullnameTitulado);
    }

    public void Insertar_BTitle(string idTittle,string faculty, string carreer, string idUser, string fullnameTitulado)
    {
        CUserBlockchain cTittle = new CUserBlockchain();
        cTittle.Insertar_BTitle(idTittle,faculty, carreer, idUser, fullnameTitulado);
    }

    #endregion

    #region RolUser
    public List<EBRoluser> Obtener_RolUser_O()
    {
        
        List<EBRoluser> eBRoluser = new List<EBRoluser>();
        CUserBlockchain cUserBlockchain = new CUserBlockchain();
        eBRoluser = cUserBlockchain.Obtener_RolUser_O().ToList();
        return eBRoluser;
    }
    #endregion

    #region Helper
    public string UltimoID_O_NombreTablaSinElCaracterI(string NombreTabla)
    {
        CUserBlockchain cSolicitudIntercambio = new CUserBlockchain();
        return cSolicitudIntercambio.UltimoID_O_NombreTablaSinElCaracterI(NombreTabla);
    }
    public string SiguienteID_O_NombreTablaSinElCaracterI(string NombreTabla)
    {
        CUserBlockchain cSolicitudIntercambio = new CUserBlockchain();
        return cSolicitudIntercambio.SiguienteID_O_NombreTablaSinElCaracterI(NombreTabla);
    }
    #endregion

    public List<IUserCareerCompleja> U_Obtener_UserCareerComplejas_O_Est()
    {
        CNetValle cNetValle = new CNetValle();
        List<IUserCareerCompleja> lstIUserCareerCompleja = new List<IUserCareerCompleja>();
        lstIUserCareerCompleja = cNetValle.U_Obtener_UserCareerComplejas_O_Est();
        return lstIUserCareerCompleja;

    }

    public ENPerson Obtener_Persona_O_Estudiante()
    {
        ENPerson eNPerson = new ENPerson();
        CNetValle cNetValle = new CNetValle();
        cNetValle.Obtener_Persona_O_Estudiante();
        return eNPerson;
    }

    public List<ENPerson> Obtener_Persona_O_EstudianteL()
    {
        List<ENPerson> ListeNPerson = new List<ENPerson>();
        CNetValle cNetValle = new CNetValle();
        cNetValle.Obtener_Persona_O_EstudianteL();
        return ListeNPerson;
    }

    public ENCareer Obtener_Carrerra_O_ID_Pedro(string id)
    {
        ENCareer eNCareer = new ENCareer();
        CNetValle cNetValle = new CNetValle();
        cNetValle.Obtener_Carrerra_O_ID_Pedro(id);
        return eNCareer;    
    }
}
