﻿using System;
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
    #endregion
    #region RolUser
    public List<EBRoluser> Obtener_RolUser_O()
    {
        List<EBRoluser> lstRolUser = new List<EBRoluser>();
        try
        {
            lstRolUser = swADNETBlockchain.Obtener_RolUser_O().ToList();
            return lstRolUser;
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