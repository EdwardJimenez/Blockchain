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
    public string NameCareer { get; set; }
    [DataMember]
    public string IDFaculty { get; set; }
    [DataMember]
    public string IDPerson { get; set; }
    public ENCareer()
    {
        IDCareer = string.Empty;
        NameCareer = string.Empty;
        IDFaculty = string.Empty;
        IDPerson = string.Empty;
    }
}