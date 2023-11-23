using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ECFacultad
/// </summary>
public class ECFacultad
{
    #region Atributos
    [DataMember]
    public int IdFacultad { get; set; }
    [DataMember]
    public string NombreFacultad { get; set; }
    [DataMember]
    public int IdEstudiante { get; set; }
    [DataMember]
    public int IdSede { get; set; }


    #endregion
    public ECFacultad()
    {
        IdFacultad = int.MinValue;
        NombreFacultad = string.Empty;
        IdEstudiante = int.MinValue;
        IdSede = int.MinValue;
    }
}