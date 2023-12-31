﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ECProyecto
/// </summary>
[DataContract]
public class ECProyecto
{
    #region Atributos
    [DataMember]    
    public int IdProyecto { get; set; }
    [DataMember]
    public string NombreProyecto { get; set; }
    [DataMember]
    public string DescripcionProyecto { get; set; }
    [DataMember]
    public string UbicacionProyecto { get; set; }
    [DataMember]
    public byte EstadoProyecto { get; set; }
    [DataMember]
    public string ImagenProyecto { get; set; }
    [DataMember]
    public byte HorasEstimadas { get; set; }
    [DataMember]
    public DateTime FechaInicioProyecto { get; set; }
    [DataMember]
    public DateTime FechaFinProyecto { get; set; }
    [DataMember]
    public DateTime FechaCreacionProyecto { get; set; }
    [DataMember]
    public int IdSede { get; set; }

    #endregion
    public ECProyecto()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
        IdProyecto = int.MinValue;
        NombreProyecto = string.Empty;
        DescripcionProyecto=string.Empty;
        UbicacionProyecto = string.Empty;
        EstadoProyecto=byte.MinValue;
        ImagenProyecto = string.Empty;
        HorasEstimadas = byte.MinValue;
        FechaInicioProyecto=DateTime.MinValue;
        FechaFinProyecto = DateTime.MinValue;
        FechaCreacionProyecto=DateTime.MinValue;
        IdSede = int.MinValue;
    }
}