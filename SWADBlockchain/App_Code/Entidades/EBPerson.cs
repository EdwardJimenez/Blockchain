using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EBPerson
/// </summary>
/// 
[DataContract]
public class EBPerson
{
    [DataMember]
    public string IdPerson { get; set; }

    [DataMember]
    public string fullName { get; set; }

    [DataMember]
    public string cellphone { get; set; }
    [DataMember]
    public DateTime registerDate { get; set; }
    [DataMember]
    public DateTime lastUpdate{ get; set; }
    [DataMember]
    public string status { get; set; }
    [DataMember]
    public string ci { get; set; }

    [DataMember]
    public string description { get; set; }

    [DataMember]
    public string IdUser { get; set; }
    [DataMember]
    public string ciExtra { get; set; }

    public EBPerson()
    {
        IdPerson = string.Empty;
        fullName = string.Empty;
        cellphone = string.Empty;
        registerDate = DateTime.MinValue;
        lastUpdate = DateTime.MinValue;
        status = string.Empty;
        ci = string.Empty;
        description = string.Empty;
        IdUser= string.Empty;
        ciExtra=string.Empty;
    }
}