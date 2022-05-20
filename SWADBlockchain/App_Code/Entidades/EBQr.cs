using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EBQr
/// </summary>
/// 
[DataContract]
public class EBQr
{
    [DataMember]
    public string IdQR { get; set; }
    [DataMember]
    public DateTime registerDate { get; set; }
    [DataMember]
    public string IdTittles { get; set; }

    public EBQr()
    {
        IdQR = string.Empty;
        registerDate = DateTime.MinValue;
        IdTittles = string.Empty;
    }
}