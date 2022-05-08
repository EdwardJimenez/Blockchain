using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CTitleBlockchain
/// </summary>
public class CTitleBlockchain
{
    #region Variables miembro
    private ASBlockchain asBlockchain;
    #endregion

    public CTitleBlockchain()
    {
        asBlockchain = new ASBlockchain();
    }
    public void Insertar_BTitle_I_idTitle_faculty(string faculty, string carreer, string statusTittle, DateTime dateDelivery, string statusDelivery, string idUser, string fullnameTitulado)
        {
            EBTittle ebTittle = new EBTittle();
            try
            {
                ebTittle.faculty = faculty;
                ebTittle.carreer = carreer;
                ebTittle.statusTittle = statusTittle;
                ebTittle.dateDelivery = dateDelivery;
                ebTittle.statusDelivery = statusDelivery;
                ebTittle.idUser = idUser;
                ebTittle.fullnameTitulado = fullnameTitulado;


                asBlockchain.Insertar_BTitle_I_idTitle_faculty(ebTittle);
            }
            catch (Exception)
            {
                throw;
            }
        }
}