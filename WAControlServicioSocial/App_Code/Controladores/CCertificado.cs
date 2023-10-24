using SWLNControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CCertificado
/// </summary>
public class CCertificado
{
    LNServicio lnServicio = new LNServicio();
    public CCertificado()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public List<ECCertificado> ObtenerCertificadosEstudianteC(int idEstudiante)
    {
        List<ECCertificado> lstCertificadosEstudiante = new List<ECCertificado>();
        try
        {
            lstCertificadosEstudiante = lnServicio.ObtenerCertificadosEstudiante(idEstudiante);
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return lstCertificadosEstudiante;
    }
}