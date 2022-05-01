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
    public string idQR { get; set; }
    [DataMember]
    public DateTime registerDate { get; set; }
    [DataMember]
    public string idTitles { get; set; }

    public EBQr()
    {
        idQR = string.Empty;
        registerDate = DateTime.MinValue;
        idTitles = string.Empty;
    }
}