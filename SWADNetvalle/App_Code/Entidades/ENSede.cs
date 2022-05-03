using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ENSede
/// </summary>
[DataContract]
public class ENSede
{
    [DataMember]
    public string IDSede { get; set; }
    [DataMember]
    public string NameSede { get; set; }
    public ENSede()
    {
        IDSede = string.Empty;
        NameSede = string.Empty;
    }
}