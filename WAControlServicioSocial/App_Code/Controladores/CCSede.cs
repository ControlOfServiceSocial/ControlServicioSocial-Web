using SWLNControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CCSede
/// </summary>
public class CCSede
{
    LNServicio lNServicio = new LNServicio();
    public ECSede ObtenerSedeIdProyecto(int idProyecto)
    {
        ECSede sede = new ECSede();
        try
        {
            sede = lNServicio.ObtenerSedeIdProyecto(idProyecto);
        }
        catch (Exception)
        {

            throw;
        }
        return sede;
    }
}