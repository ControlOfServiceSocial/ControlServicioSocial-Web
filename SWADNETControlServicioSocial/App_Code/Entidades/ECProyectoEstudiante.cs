using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ECProyectoEstudiante
/// </summary>
public class ECProyectoEstudiante
{
    #region Atributos
    [DataMember]
    public int IdProyectoEstudiante { get; set; }
    [DataMember]
    public int IdProyecto { get; set; }
    [DataMember]
    public int IdEstudiante { get; set; }
    [DataMember]
    public int HoraAcumulada { get; set; }
    [DataMember]
    public DateTime HoraInicio { get; set; }
    [DataMember]
    public DateTime HoraFinal { get; set; }
    [DataMember]
    public string LatitudInicial { get; set; }
    [DataMember]
    public string LongitudInicial { get; set; }
    [DataMember]
    public string LatitudFinal { get; set; }
    [DataMember]
    public string LongitudFinal { get; set; }
    #endregion
    public ECProyectoEstudiante()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
        IdProyectoEstudiante = int.MinValue;
        IdProyecto = int.MinValue;
        IdEstudiante = int.MinValue;
        HoraAcumulada = int.MinValue;
        HoraInicio = DateTime.MinValue;
        HoraFinal = DateTime.MinValue;
        LatitudInicial = string.Empty;
        LongitudInicial = string.Empty;
        LatitudFinal = string.Empty;
        LongitudFinal = string.Empty;
    }
}