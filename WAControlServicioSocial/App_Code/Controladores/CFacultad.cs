using SWLNControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CFacultad
/// </summary>
public class CFacultad: System.Web.UI.Page
{
    LNServicio lnServicio = new LNServicio();
    public ECFacultad ObtenerCFacultadPorId_C(int idEstudiante)
    {
        ECFacultad facultad = new ECFacultad();
        try
        {
            facultad = lnServicio.ObtenerCFacultadPorId(idEstudiante);
        }
        catch (Exception)
        {
            // Manejar excepciones aquí
            throw;
        }
        return facultad;
    }
}