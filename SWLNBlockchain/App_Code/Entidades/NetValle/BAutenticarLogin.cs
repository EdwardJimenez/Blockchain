using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de BAutenticarLogin
/// </summary>
public class BAutenticarLogin
{
    public string Id_Person { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    
    public BAutenticarLogin()
    {
        Id_Person = string.Empty;
        Email = string.Empty;
        Password = string.Empty;
    }
}