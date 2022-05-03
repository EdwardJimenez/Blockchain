using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ENFaculty
/// </summary>
[DataContract]
public class ENFaculty
{
    [DataMember]
    public string IDFaculty { get; set; }
    [DataMember]
    public string NameFaculty { get; set; }
    [DataMember]
    public string IDSede { get; set; }
    public ENFaculty()
    {
        IDFaculty = string.Empty;
        NameFaculty = string.Empty;
        IDSede = string.Empty;
    }
}