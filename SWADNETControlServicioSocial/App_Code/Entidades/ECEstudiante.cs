using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ECEstudiante
/// </summary>
public class ECEstudiante
{
    #region Atributos
    [DataMember]
    public int IdEstudiante { get; set; }
    [DataMember]
    public string NombreEstudiante { get; set; }
    [DataMember]
    public string ApellidoPaternoEstudiante { get; set; }
    [DataMember]
    public string ApellidoMaternoEstudiante { get; set; }
    [DataMember]
    public string EmailEstudiante { get; set; }
    [DataMember]
    public string TelefonoEstudiante { get; set; }
    [DataMember]
    public DateTime FechaRegistroEstudiante { get; set; }
    [DataMember]
    public DateTime FechaActualizacion { get; set; }
    #endregion

    public ECEstudiante()
    {
        IdEstudiante = int.MinValue;
        NombreEstudiante = string.Empty;
        ApellidoPaternoEstudiante = string.Empty;
        ApellidoMaternoEstudiante= string.Empty;
        EmailEstudiante = string.Empty;
        TelefonoEstudiante = string.Empty;
        FechaRegistroEstudiante = DateTime.MinValue;
        FechaActualizacion = DateTime.MinValue;
    }
}