using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CBCareer
/// </summary>
public class CNCareer
{
    private ADNCareer aDNCareer;

    public CNCareer()
    {
        aDNCareer = new ADNCareer();
    }
    public ENCareer Obtener_Carrerra_O_ID_Pedro(string id)
    {
        ENCareer eNCareer = new ENCareer();
        DTONCareer dTONCareer = aDNCareer.Obtener_Carrerra_O_ID_Pedro(id);
        foreach (DTONCareer.CareerUniversityRow drCareerUniversity in dTONCareer.CareerUniversity.Rows)
        {
            eNCareer.IDCareer = drCareerUniversity.IDCareerUniversity.ToString();
            eNCareer.CareerName = drCareerUniversity.CareerName.ToString();
            eNCareer.SedeName = drCareerUniversity.SedeName.ToString();
            eNCareer.FacultyName = drCareerUniversity.FacultyName.ToString();
        }
        return eNCareer;
    }
}