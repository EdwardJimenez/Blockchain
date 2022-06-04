using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SWADBlockChain;
/// <summary>
/// Descripción breve de ASBlockchain
/// </summary>
public class ASBlockchain
{
    private SWADNETBlockchainClient swADNETBlockchain;
    public ASBlockchain()
    {

        swADNETBlockchain = new SWADNETBlockchainClient();
    }

    #region BUser
    public EBUser Obtener_RolUser_O_Search(string email, string password)
    {
        EBUser eUser = new EBUser();
        try
        {
            eUser = swADNETBlockchain.Obtener_RolUser_O_Search(email, password);
            return eUser;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EBUser> Obtener_User_O()
    {
        List<EBUser> lstEiCarrera = new List<EBUser>();
        try
        {
            lstEiCarrera = swADNETBlockchain.Obtener_User_O().ToList();
            return lstEiCarrera;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EBUser Obtener_BUser_O_iduser(string Id_User)
    {
        EBUser eiUser = new EBUser();
        try
        {
            eiUser = swADNETBlockchain.Obtener_BUser_O_iduser(Id_User);
            return eiUser;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Insertar_BUser_I_idUser_email(EBUser bUser)
    {
        try
        {
            swADNETBlockchain.Insertar_BUser_I_idUser_email(bUser);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Insertar_BUser_I(EBUser bUser)
    {
        try
        {
            swADNETBlockchain.Insertar_BUser_I(bUser);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Actualizar_BUser_I_idUser_email(EBUser ebUser)
    {
        try
        {
            swADNETBlockchain.Actualizar_BUser_I_idUser_email(ebUser);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region BTitle 
    public List<EBTittle> BTittle_O_TO_Upload()
    {
        List<EBTittle> lstEbTitle = new List<EBTittle>();
        try
        {
            lstEbTitle = swADNETBlockchain.BTittle_O_TO_Upload().ToList();
            return lstEbTitle;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EBTittle> BTittle_O_State2()
    {
        List<EBTittle> lstEbTitle = new List<EBTittle>();
        try
        {
            lstEbTitle = swADNETBlockchain.BTittle_O_State2().ToList();
            return lstEbTitle;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EBTittle> BTittle_O_State3()
    {
        List<EBTittle> lstEbTitle = new List<EBTittle>();
        try
        {
            lstEbTitle = swADNETBlockchain.BTittle_O_State3().ToList();
            return lstEbTitle;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EBTittle> BTittle_O_State4()
    {
        List<EBTittle> lstEbTitle = new List<EBTittle>();
        try
        {
            lstEbTitle = swADNETBlockchain.BTittle_O_State4().ToList();
            return lstEbTitle;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EBTittle> BTittle_O_State5()
    {
        List<EBTittle> lstEbTitle = new List<EBTittle>();
        try
        {
            lstEbTitle = swADNETBlockchain.BTittle_O_State5().ToList();
            return lstEbTitle;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EBTittle> BTittle_O_State6()
    {
        List<EBTittle> lstEbTitle = new List<EBTittle>();
        try
        {
            lstEbTitle = swADNETBlockchain.BTittle_O_State6().ToList();
            return lstEbTitle;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EBTittle> BTittle_O_State7()
    {
        List<EBTittle> lstEbTitle = new List<EBTittle>();
        try
        {
            lstEbTitle = swADNETBlockchain.BTittle_O_State7().ToList();
            return lstEbTitle;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EBTittle> Obtener_Title_O()
    {
        List<EBTittle> lstEbTitle = new List<EBTittle>();
        try
        {
            lstEbTitle = swADNETBlockchain.Obtener_Title_O().ToList();
            return lstEbTitle;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public List<EBTittle> Obtener_Title_O_ListGraduates()
    {
        List<EBTittle> lstEbTitle = new List<EBTittle>();
        try
        {
            lstEbTitle = swADNETBlockchain.Obtener_Title_O_ListGraduates().ToList();
            return lstEbTitle;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Actualizar_ITitle_statusTitle(EBTittle ebTitle)
    {
        try
        {
            swADNETBlockchain.Actualizar_ITitle_statusTitle(ebTitle);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Eliminar_ITitle_statusTitle(EBTittle ebTitle)
    {
        try
        {
            swADNETBlockchain.Eliminar_ITitle_statusTitle(ebTitle);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Actualizar_ITitle(EBTittle ebTitle)
    {
        try
        {
            swADNETBlockchain.Actualizar_ITitle(ebTitle);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Insertar_BTitle_I_idTitle_faculty(EBTittle ebTittle)
    {
        try
        {
            swADNETBlockchain.Insertar_BTitle_I_idTitle_faculty(ebTittle);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public EBTittle BUser_O_Search(string name)
    {
        EBTittle eTittle = new EBTittle();
        try
        {
            eTittle = swADNETBlockchain.BUser_O_Search(name);
            return eTittle;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public List<EBTittle> BTittle_O_Faculty(string faculty)
    {
        List<EBTittle> lstEbTitle = new List<EBTittle>();
        try
        {
            lstEbTitle = swADNETBlockchain.BTittle_O_Faculty(faculty).ToList();
            return lstEbTitle;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public List<EBTittle> BTittle_O_CARREER(string carreer)
    {
        List<EBTittle> lstEbTitle = new List<EBTittle>();
        try
        {
            lstEbTitle = swADNETBlockchain.BTittle_O_CARREER(carreer).ToList();
            return lstEbTitle;
        }
        catch (Exception)
        {
            throw;
        }
    }


    public void BTittle_update_statusTittle_7(EBTittle ebTitle)
    {
        try
        {
            swADNETBlockchain.BTittle_update_statusTittle_7(ebTitle);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void BTittle_update_statusTittle_6(EBTittle ebTitle)
    {
        try
        {
            swADNETBlockchain.BTittle_update_statusTittle_6(ebTitle);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void BTittle_update_statusTittle_5(EBTittle ebTitle)
    {
        try
        {
            swADNETBlockchain.BTittle_update_statusTittle_5(ebTitle);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void BTittle_update_statusTittle_4(EBTittle ebTitle)
    {
        try
        {
            swADNETBlockchain.BTittle_update_statusTittle_4(ebTitle);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void BTittle_update_statusTittle_3(EBTittle ebTitle)
    {
        try
        {
            swADNETBlockchain.BTittle_update_statusTittle_3(ebTitle);
        }
        catch (Exception)
        {
            throw;
        }
    }
    
    public void Insertar_BTitle(EBTittle ebTittle)
    {
        try
        {
            swADNETBlockchain.Insertar_BTitle(ebTittle);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Actualizar_BTittle_ConfirmarEntrega(EBTittle ebTitle)
    {
        try
        {
            swADNETBlockchain.Actualizar_BTittle_ConfirmarEntrega(ebTitle);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region RolUser
    public List<EBRoluser> Obtener_RolUser_O()
    {
        List<EBRoluser> eBRolusers = new List<EBRoluser>();
        try
        {
            eBRolusers = swADNETBlockchain.Obtener_RolUser_O().ToList();
            return eBRolusers;
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region Helper
    public string UltimoID_O_NombreTablaSinElCaracterI(string NombreTabla)
    {
        try
        {
            return swADNETBlockchain.UltimoID_O_NombreTablaSinElCaracterI(NombreTabla);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public string SiguienteID_O_NombreTablaSinElCaracterI(string NombreTabla)
    {
        try
        {
            return swADNETBlockchain.SiguienteID_O_NombreTablaSinElCaracterI(NombreTabla);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}