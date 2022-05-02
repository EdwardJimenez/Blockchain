using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EBRoluser
/// </summary>
/// 
[DataContract]
public class EBRoluser
{
    [DataMember]
    public string idrolUser { get; set; }
    [DataMember]
    public string name { get; set; }
    [DataMember]
    public string status { get; set; }

    public EBRoluser()
    {
        idrolUser = string.Empty;
        name = string.Empty;
        status = string.Empty;
    }
}