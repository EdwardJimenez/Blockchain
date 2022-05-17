using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SWADNetValle;

/// <summary>
/// Descripción breve de CNetValle
/// </summary>
public class CNetValle
{
    private ASNetValle aSNetValle;
    public CNetValle()
    {
        aSNetValle = new ASNetValle();
    }

    #region user
    public List<ENPerson> Obtener_Persona_O_EstudianteL()
    {
        List<ENPerson> listENPerson = new List<ENPerson>();
        try
        {
            listENPerson = aSNetValle.Obtener_Persona_O_EstudianteL();
            return listENPerson;
        }
        catch (Exception)
        {

            throw;
        }
    }
    public ENPerson Obtener_Persona_O_Estudiante()
    {
        ENPerson eNPerson = new ENPerson();
        try
        {
            eNPerson =  aSNetValle.Obtener_Persona_O_Estudiante();
            return eNPerson;
        }
        catch (Exception)
        {

            throw;
        }
    }
    #endregion

    #region careerUniversity
    public ENCareer Obtener_Carrerra_O_ID_Pedro(string id)
    {
        ENCareer eNCareer = new ENCareer();
        try
        {
            eNCareer = aSNetValle.Obtener_Carrerra_O_ID_Pedro(id);
            return eNCareer;
        }
        catch (Exception)
        {

            throw;
        }
    }
    #endregion

    #region IUserCareerCompleja
    public List<IUserCareerCompleja> U_Obtener_UserCareerComplejas_O_Est()
    {
        List<IUserCareerCompleja> lstUserCareerCompleja = new List<IUserCareerCompleja>();
        List<ENPerson> lstENPerson = new List<ENPerson>();
        IUserCareerCompleja userCareerCompleja;
        ENCareer eNCareer = new ENCareer();
        try
        {
            lstENPerson = aSNetValle.Obtener_Persona_O_EstudianteL();
            foreach (ENPerson eNPerson in lstENPerson)
            {
                eNCareer = aSNetValle.Obtener_Carrerra_O_ID_Pedro(eNPerson.IDCareer);
                userCareerCompleja = new IUserCareerCompleja();
                userCareerCompleja.IDPerson = eNPerson.IDPerson;
                userCareerCompleja.Fullname = eNPerson.Fullname;
                userCareerCompleja.IDCareer = eNCareer.IDCareer;
                userCareerCompleja.CareerName = eNCareer.CareerName;
                userCareerCompleja.FacultyName = eNCareer.FacultyName;
                userCareerCompleja.SedeName = eNCareer.SedeName;
                lstUserCareerCompleja.Add(userCareerCompleja);
            }
            return lstUserCareerCompleja;
        }
        catch (Exception)
        {

            throw;
        }
    }

    #endregion
}