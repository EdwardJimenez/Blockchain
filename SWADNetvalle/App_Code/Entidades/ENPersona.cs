using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ENPersona
/// </summary>
[DataContract]
public class ENPersona
{
    [DataMember]
    public string IDPerson { get; set; }
    [DataMember]
    public string FirstName { get; set; }
    [DataMember]
    public string SecondName { get; set; }
    [DataMember]
    public string LastName { get; set; }
    [DataMember]
    public string SecondLastName { get; set; }
    [DataMember]
    public string Phone { get; set; }
    [DataMember]
    public string CI { get; set; }
    [DataMember]
    public string ExtCI { get; set; }
    [DataMember]
    public string Mail { get; set; }
    [DataMember]
    public string Password { get; set; }
    [DataMember]
    public string Rol { get; set; }
    public ENPersona()
    {
        IDPerson = string.Empty;
        FirstName = string.Empty;
        SecondName = string.Empty;
        LastName = string.Empty;
        SecondLastName = string.Empty;
        Phone = string.Empty;
        CI = string.Empty;
        ExtCI = string.Empty;
        Mail = string.Empty;
        Password = string.Empty;
        Rol = string.Empty;
    }
}