using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de IUserCareerCompleja
/// </summary>
public class IUserCareerCompleja
{
    [DataMember]
    public string IDPerson { get; set; }
    [DataMember]
    public string Fullname { get; set; }
    [DataMember]
    public string Phone { get; set; }
    [DataMember]
    public string CI { get; set; }
    [DataMember]
    public string ExtCI { get; set; }
    [DataMember]
    public string Mail { get; set; }
    //[DataMember]
    //public string Password { get; set; }
    // [DataMember]
    //public string Rol { get; set; }
    //[DataMember]
    //public string IDCareer { get; set; }

    [DataMember]
    public string IDCareer { get; set; }
    [DataMember]
    public string CareerName { get; set; }
    [DataMember]
    public string FacultyName { get; set; }
    [DataMember]
    public string SedeName { get; set; }


    public IUserCareerCompleja()
    {
        IDPerson = string.Empty;
        Fullname = string.Empty;
        Phone = string.Empty;
        CI = string.Empty;
        ExtCI = string.Empty;
        Mail = string.Empty;
        IDCareer = string.Empty;
        CareerName = string.Empty;
        FacultyName = string.Empty;
        SedeName = string.Empty;
    }
}