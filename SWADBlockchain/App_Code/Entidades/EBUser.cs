using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EBUser
/// </summary>
[DataContract]
public class EBUser
{

    [DataMember]
    public string IdUser { get; set; }
    [DataMember]
    public string Email { get; set; }
    [DataMember]
    public string Password { get; set; }
    //[DataMember]
    //public string status { get; set; }
    [DataMember]
    public string UserNetvalle { get; set; }
    [DataMember]
    public string IdRolUser { get; set; }
    [DataMember]
    public string IdTitle { get; set; }
    //[DataMember]
    //public DateTime registerDate { get; set; }
    //[DataMember]
    //public DateTime lastUpdate { get; set; }

    public EBUser()
    {
        IdUser = string.Empty;
        Email = string.Empty;
        Password = string.Empty;
        UserNetvalle = string.Empty;
        IdRolUser = string.Empty;
        IdTitle = string.Empty;
    }
}