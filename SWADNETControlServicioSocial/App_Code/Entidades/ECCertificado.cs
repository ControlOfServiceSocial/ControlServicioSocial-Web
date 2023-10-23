using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de ECCertificado
/// </summary>
public class ECCertificado
{
    #region Atributos
    [DataMember]
    public int IdCertificado { get; set; }
    [DataMember]
    public string DocumentoCertificado { get; set; }
    [DataMember]
    public int IdEstudiante { get; set; }
    [DataMember]
    public string TituloCertificado { get; set; }
    [DataMember]
    public DateTime CargaHoraria { get; set; }
    #endregion
    public ECCertificado()
    {
        IdCertificado=int.MinValue;
        DocumentoCertificado=string.Empty;
        IdEstudiante=int.MinValue;
        TituloCertificado = string.Empty;
        CargaHoraria=DateTime.MinValue;
    }
}