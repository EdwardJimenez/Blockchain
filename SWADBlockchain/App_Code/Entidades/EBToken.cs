using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EBToken
/// </summary>
[DataContract]
public class EBQrToken { 
    [DataMember]
    public string idToken { get; set; }
    [DataMember]
    public string typeToken { get; set; }
    [DataMember]
    public string idTittles { get; set; }

    public EBQrToken()
    {
        idToken = string.Empty;
        typeToken = string.Empty;
        idTittles = string.Empty;
    }
}