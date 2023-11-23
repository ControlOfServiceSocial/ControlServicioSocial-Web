using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ECSede
/// </summary>
public class ECSede
{
    [DataMember]
    public int IdSede { get; set; }
    [DataMember]
    public string NombreSede { get; set; }
    public ECSede()
    {
        IdSede = int.MinValue;
        NombreSede = string.Empty;
    }
}