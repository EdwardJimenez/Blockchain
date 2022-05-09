using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EBTitle
/// </summary>
/// 
[DataContract]
public class EBTittle
{
    [DataMember]
    public string IdTittles { get; set; }
    [DataMember]
    public DateTime registerDate { get; set; }
    [DataMember]
    public DateTime lastUpdate { get; set; }
    [DataMember]
    public string status { get; set; }
    [DataMember]
    public string faculty { get; set; }
    [DataMember]
    public string carreer { get; set; }
    [DataMember]
    public string statusTitle { get; set; }
    [DataMember]
    public DateTime dateDelivery { get; set; }
    [DataMember]
    public string statusDelivery { get; set; }
    [DataMember]
    public string idUser { get; set; }
    [DataMember]
    public string fullNameTitulado { get; set; }

    
    public EBTittle()
    {
        IdTittles = string.Empty;
        registerDate = DateTime.MinValue;
        lastUpdate = DateTime.MinValue;
        status = string.Empty;
        faculty = string.Empty;
        carreer = string.Empty;
        statusTitle = string.Empty;
        dateDelivery = DateTime.MinValue;
        statusDelivery = string.Empty;
        idUser = string.Empty;  
        fullNameTitulado = string.Empty;    
    }

    
}