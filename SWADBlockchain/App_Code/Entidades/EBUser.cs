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
    [DataMember]
    public string status { get; set; }
    [DataMember]
    public string UserNetvalle { get; set; }
    [DataMember]
    public string IdRolUser { get; set; }
    [DataMember]
    public string Fullname { get; set; }
    [DataMember]
    public string Cellphone { get; set; }
    [DataMember]
    public string CI { get; set; }
    [DataMember]
    public string Descripcion { get; set; }
    [DataMember]
    public string CIExtra { get; set; }

    public EBUser()
    {
        IdUser = string.Empty;
        Email = string.Empty;
        Password = string.Empty;
        status = string.Empty;
        UserNetvalle = string.Empty;
        IdRolUser = string.Empty;
        Fullname = string.Empty;
        Cellphone = string.Empty;
        CI = string.Empty;  
        Descripcion = string.Empty; 
        CIExtra = string.Empty;
    }
}