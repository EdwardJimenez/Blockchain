using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EBAudit
/// </summary>
/// 

[DataContract]
public class EBAudit
{
    [DataMember]
    public string IdAudit { get; set; }
    [DataMember]
    public string description { get; set; }
    [DataMember]
    public DateTime registerDate { get; set; }
    [DataMember]
    public DateTime lastUpdate { get; set; }
    [DataMember]
    public string status { get; set; }

    public EBAudit()
    {
        IdAudit = string.Empty;
        description = string.Empty;
        registerDate = DateTime.MinValue;
        lastUpdate = DateTime.MinValue;
        status = string.Empty;
    }
}