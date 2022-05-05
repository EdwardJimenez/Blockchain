using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de BSolicitudCompleja
/// </summary>

[DataContract]
public class BSolicitudCompleja
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
    public DateTime lastUpdate { get; set; }
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



    [DataMember]
    public string IDPersonN { get; set; }
    [DataMember]
    public string FirstNameN { get; set; }
    [DataMember]
    public string SecondNameN { get; set; }
    [DataMember]
    public string LastNameN { get; set; }
    [DataMember]
    public string SecondLastNameN { get; set; }
    [DataMember]
    public string PhoneN { get; set; }
    [DataMember]
    public string CIN { get; set; }
    [DataMember]
    public string ExtCIN { get; set; }
    [DataMember]
    public string MailN { get; set; }
    [DataMember]
    public string PasswordN { get; set; }
    [DataMember]
    public string RolN { get; set; }
    public BSolicitudCompleja()
    {
        IdPerson = string.Empty;
        fullName = string.Empty;
        cellphone = string.Empty;
        registerDate = DateTime.MinValue;
        lastUpdate = DateTime.MinValue;
        status = string.Empty;
        ci = string.Empty;
        description = string.Empty;
        IdUser = string.Empty;
        ciExtra = string.Empty;


        IDPersonN = string.Empty;
        FirstNameN = string.Empty;
        SecondNameN = string.Empty;
        LastNameN = string.Empty;
        SecondLastNameN = string.Empty;
        PhoneN = string.Empty;
        CIN = string.Empty;
        ExtCIN = string.Empty;
        MailN = string.Empty;
        PasswordN = string.Empty;
        RolN = string.Empty;
    }
}