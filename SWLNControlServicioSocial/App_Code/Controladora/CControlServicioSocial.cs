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
    #region insert
    public void Insertar_CProyecto_I(string NombreProyecto, string DescripcionProyecto, string UbicacionProyecto, byte EstadoProyecto, string ImagenProyecto, byte HorasEstimadas, DateTime FechaInicioProyecto, DateTime FechaFinProyecto, DateTime FechaCreacionProyecto, int IdSede)
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
            eCProyecto.IdSede = IdSede;
            asNetControlServicioSocial.Insertar_CProyecto_I(eCProyecto);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion

    #region get all
    public List<ECProyecto> Obtener_CProyecto_O()
    {
        List<ECProyecto> lstEcProyecto = new List<ECProyecto>();
        try
        {
            lstEcProyecto = asNetControlServicioSocial.Obtener_CProyecto_O().ToList();
        }
        catch (Exception)
        {

            throw;
        }
        return lstEcProyecto;
    }
    #endregion

    #region get
    public List<ECProyecto> Obtener_CProyecto_O_ID(int Idproyecto)
    {
        List<ECProyecto> lstEcProyecto = new List<ECProyecto>();
        try
        {
            lstEcProyecto = asNetControlServicioSocial.Obtener_CProyecto_O_ID(Idproyecto).ToList();
        }
        catch (Exception)
        {

            throw;
        }
        return lstEcProyecto;
    }
    #endregion

    #region update
    public void Actualizar_CProyecto_A(int IdProyecto, string NombreProyecto, string DescripcionProyecto, string UbicacionProyecto, byte EstadoProyecto, string ImagenProyecto, byte HorasEstimadas, DateTime FechaInicioProyecto, DateTime FechaFinProyecto, DateTime FechaCreacionProyecto, int IdSede)
    {
        ECProyecto eCProyecto = new ECProyecto();
        try
        {
            eCProyecto.IdProyecto = IdProyecto;
            eCProyecto.NombreProyecto = NombreProyecto;
            eCProyecto.DescripcionProyecto = DescripcionProyecto;
            eCProyecto.UbicacionProyecto = UbicacionProyecto;
            eCProyecto.EstadoProyecto = EstadoProyecto;
            eCProyecto.ImagenProyecto = ImagenProyecto;
            eCProyecto.HorasEstimadas = HorasEstimadas;
            eCProyecto.FechaInicioProyecto = FechaInicioProyecto;
            eCProyecto.FechaFinProyecto = FechaFinProyecto;
            eCProyecto.FechaCreacionProyecto = FechaCreacionProyecto;
            eCProyecto.IdSede = IdSede;
            asNetControlServicioSocial.Actualizar_CProyecto_A(eCProyecto);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    #endregion
    #endregion
}