using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de BUserRolUserTitleCompleja
/// </summary>
[DataContract]
public class BUserRolUserTitleCompleja
{

    [DataMember]
    public string IdUser { get; set; }

    [DataMember]
    public string idrolUser { get; set; }
    [DataMember]
    public string name { get; set; }
    [DataMember]
    public string status { get; set; }

    [DataMember]
    public string IdTittles { get; set; }
    [DataMember]
    public DateTime registerDate { get; set; }
    [DataMember]
    public DateTime lastUpdate { get; set; }

    [DataMember]
    public string statusRegister { get; set; }
    [DataMember]
    public string faculty { get; set; }
    [DataMember]
    public string carreer { get; set; }
    [DataMember]
    public string statusTitle { get; set; }
    [DataMember]
    public string dateDelivery { get; set; }
    [DataMember]
    public string statusDelivery { get; set; }
    [DataMember]
    public string impression { get; set; }
    [DataMember]
    public string idUser { get; set; }

    [DataMember]
    public string Email { get; set; }
    [DataMember]
    public string Password { get; set; }
  
    [DataMember]
    public string UserNetvalle { get; set; }
    [DataMember]
    public string IdRolUser { get; set; }
    [DataMember]
    public string IdTitle { get; set; }

    public BUserRolUserTitleCompleja()
    {
        this.idUser = string.Empty;
        this.idrolUser = string.Empty;
        this.name =  string.Empty;
        this.status =string.Empty;
        IdTittles =  string.Empty;
        this.registerDate = DateTime.MinValue;
        this.lastUpdate = DateTime.MinValue;
        this.statusRegister =  string.Empty;
        this.faculty =  string.Empty;
        this.carreer =  string.Empty;
        this.statusTitle =  string.Empty;
        this.dateDelivery =  string.Empty;
        this.statusDelivery =  string.Empty;
        this.impression =  string.Empty;
        this.idUser =  string.Empty;
        Email =  string.Empty;
        Password =  string.Empty;
        UserNetvalle =  string.Empty;
        IdRolUser =  string.Empty;
        IdTitle =  string.Empty;
    }

}