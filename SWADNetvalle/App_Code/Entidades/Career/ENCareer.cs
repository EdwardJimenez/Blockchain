using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ENCareer
/// </summary>
[DataContract]
public class ENCareer
{
    [DataMember]
    public string IDCareer { get; set; }
    [DataMember]
    public string CareerName { get; set; }
    [DataMember]
    public string FacultyName { get; set; }
    [DataMember]
    public string SedeName { get; set; }


    public ENCareer()
    {
        IDCareer = string.Empty;
        CareerName = string.Empty;
        FacultyName = string.Empty;
        SedeName = string.Empty;
    }
}