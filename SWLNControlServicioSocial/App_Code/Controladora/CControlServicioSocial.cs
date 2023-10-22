using SWADNETControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CControlServicioSocial
/// </summary>
public class CControlServicioSocial
{
    ASNETControlServicioSocial asNetControlServicioSocial;
    public CControlServicioSocial()
    {
        asNetControlServicioSocial = new ASNETControlServicioSocial();
    }

    #region Metodos Publicos
    public List<ECEstudiante> Obtener_CEstudiante_O()
    {
        List<ECEstudiante> lstEcEstudiante = new List<ECEstudiante>();
        try
        {
            lstEcEstudiante = asNetControlServicioSocial.Obtener_CEstudiante_O().ToList();
        }
        catch (Exception)
        {

            throw;
        }
        return lstEcEstudiante;
    }
    #endregion
    #region Metodos Publicos Proyecto
    public void Insertar_CProyecto_I(string NombreProyecto, string DescripcionProyecto, string UbicacionProyecto, string EstadoProyecto, byte[] ImagenProyecto, byte HorasEstimadas, DateTime FechaInicioProyecto, DateTime FechaFinProyecto, DateTime FechaCreacionProyecto)
    {
        ECProyecto eCProyecto = new ECProyecto();
        try
        {
            eCProyecto.NombreProyecto = NombreProyecto;
            eCProyecto.DescripcionProyecto = DescripcionProyecto;
            eCProyecto.UbicacionProyecto = UbicacionProyecto;
            eCProyecto.EstadoProyecto = EstadoProyecto;
            eCProyecto.ImagenProyecto = ImagenProyecto;
            eCProyecto.HorasEstimadas = HorasEstimadas;
            eCProyecto.FechaInicioProyecto = FechaInicioProyecto;
            eCProyecto.FechaFinProyecto = FechaFinProyecto;
            eCProyecto.FechaCreacionProyecto = FechaCreacionProyecto;
            asNetControlServicioSocial.Insertar_CProyecto_I(eCProyecto);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion
}