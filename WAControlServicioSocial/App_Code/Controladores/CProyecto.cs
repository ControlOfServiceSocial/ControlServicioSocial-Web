using SWLNControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CProyecto
/// </summary>
public class CProyecto : System.Web.UI.Page
{
    LNServicio lnServicio = new LNServicio();

    public CProyecto()
    {
        
    }
    public void Insertar_CProyecto_I_CC(string NombreProyecto, string DescripcionProyecto, string UbicacionProyecto, byte EstadoProyecto, string ImagenProyecto, byte HorasEstimadas, DateTime FechaInicioProyecto, DateTime FechaFinProyecto, DateTime FechaCreacionProyecto)
    {
        try
        {
            lnServicio.Insertar_CProyecto_I(NombreProyecto, DescripcionProyecto, UbicacionProyecto, EstadoProyecto, ImagenProyecto, HorasEstimadas, FechaInicioProyecto, FechaFinProyecto, FechaCreacionProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public List<ECProyecto> Obtener_CProyecto_O_CC()
    {
        List<ECProyecto> lstEcProyecto = new List<ECProyecto>();
        try
        {
            lstEcProyecto = lnServicio.Obtener_CProyecto_O().ToList();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return lstEcProyecto;
    }
}
