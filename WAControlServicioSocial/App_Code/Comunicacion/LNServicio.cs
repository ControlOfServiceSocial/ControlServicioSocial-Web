using SWLNControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de LNServicio
/// </summary>
public class LNServicio
{
    #region Variables
    private SWLNControlServicioSocialClient swlnControlServicioSocial;
    #endregion
    public LNServicio()
    {
        swlnControlServicioSocial = new SWLNControlServicioSocialClient();
    }

    #region Metodos Publicos

    #region CEstudiante 
    public List<ECEstudiante> Obtener_CEstudiante_O()
    {
        List<ECEstudiante> lstEcEstudiante = new List<ECEstudiante>();
        try
        {
            lstEcEstudiante = swlnControlServicioSocial.Obtener_CEstudiante_O().ToList();
        }
        catch (Exception)
        {

            throw;
        }

        return lstEcEstudiante;
    }
    #endregion
    #region CProyecto
    public void Insertar_CProyecto_I(string NombreProyecto, string DescripcionProyecto, string UbicacionProyecto, byte EstadoProyecto, string ImagenProyecto, byte HorasEstimadas, DateTime FechaInicioProyecto, DateTime FechaFinProyecto, DateTime FechaCreacionProyecto)
    {
        try
        {
            swlnControlServicioSocial.Insertar_CProyecto_I(NombreProyecto, DescripcionProyecto, UbicacionProyecto, EstadoProyecto, ImagenProyecto, HorasEstimadas, FechaInicioProyecto, FechaFinProyecto, FechaCreacionProyecto);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public List<ECProyecto> Obtener_CProyecto_O()
    {
        List<ECProyecto> lstEcProyecto = new List<ECProyecto>();
        try
        {
            lstEcProyecto = swlnControlServicioSocial.Obtener_CProyecto_O().ToList();
        }
        catch (Exception)
        {

            throw;
        }

        return lstEcProyecto;
    }
    #endregion
    #endregion
}