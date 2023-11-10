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

    #region Estudiante
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

    public ECEstudiante ObtenerEstudiantePorId(int idEstudiante)
    {
        ECEstudiante estudiante = new ECEstudiante();
        try
        {
            estudiante = asNetControlServicioSocial.ObtenerEstudiantePorId(idEstudiante);
        }
        catch (Exception)
        {
            // Manejar excepciones aquí
            throw;
        }
        return estudiante;
    }
    #endregion

    #region Facultad
    public ECFacultad ObtenerCFacultadPorId(int idEstudiante)
    {
        ECFacultad facultad = new ECFacultad();
        try
        {
            facultad = asNetControlServicioSocial.ObtenerCFacultadPorId(idEstudiante);
        }
        catch (Exception)
        {
            // Manejar excepciones aquí
            throw;
        }
        return facultad;
    }
    #endregion

    #region Certificados
    public List<ECCertificado> ObtenerCertificadosEstudiante(int idEstudiante)
    {
        List<ECCertificado> lstCertificadosEstudiante = new List<ECCertificado>();
        try
        {
            lstCertificadosEstudiante = asNetControlServicioSocial.ObtenerCertificadosEstudiante(idEstudiante);
        }
        catch (Exception)
        {
            throw;
        }
        return lstCertificadosEstudiante;
    }
    #endregion

    public List<ECProyecto> Obtener_CProyecto_O()
    {
        List<ECProyecto> lstEcProyecto=new List<ECProyecto>();
        try
        {
            lstEcProyecto= asNetControlServicioSocial.Obtener_CProyecto_O();
        }
        catch (Exception)
        {

            throw;
        }
        return lstEcProyecto;
    }
    public List<ECCertificado> Obtener_CCertificado_O()
    {
        List<ECCertificado> lstEcCertifiado = new List<ECCertificado>();
        try
        {
            lstEcCertifiado = asNetControlServicioSocial.Obtener_CCertificado_O();
        }
        catch (Exception)
        {

            throw;
        }
        return lstEcCertifiado;
    }
    public List<ECProyectoEstudiante> Obtener_CProyectoEstudiante_O()
    {
        List<ECProyectoEstudiante> lstEcProyectoEstudiante = new List<ECProyectoEstudiante>();
        try
        {
            lstEcProyectoEstudiante = asNetControlServicioSocial.Obtener_CProyectoEstudiante_O();
        }
        catch (Exception)
        {

            throw;
        }
        return lstEcProyectoEstudiante;
    }   
    public ECProyecto Obtener_CProyecto_O_IdProyecto(int IdProyecto)
    {
       ECProyecto eCProyecto=new ECProyecto();
        try
        {
            eCProyecto = asNetControlServicioSocial.Obtener_CProyecto_O_IdProyecto(IdProyecto);
        }
        catch (Exception)
        {

            throw;
        }
        return eCProyecto;
    }

    public List<ECProyecto> Obtener_CProyecto_O_CProyecto(int idEstudiante)
    {
        List<ECProyecto> lstECProyecto = new List<ECProyecto>();
        try
        {
            lstECProyecto = asNetControlServicioSocial.Obtener_CProyecto_O_CProyecto(idEstudiante);
        }
        catch (Exception)
        {

            throw;
        }
        return lstECProyecto;
    }

    public ECSede ObtenerSedeIdProyecto(int idProyecto)
    {
        ECSede sede = new ECSede();
        try
        {
            sede = asNetControlServicioSocial.ObtenerSedeIdProyecto(idProyecto);
        }
        catch (Exception)
        {

            throw;
        }
        return sede;
    }

    public ECProyectoEstudiante ObtenerProyectoEstudiantePorIds(int IdProyecto, int IdEstudiante)
    {
        ECProyectoEstudiante proyectoEstudiante = new ECProyectoEstudiante();
        try
        {
            proyectoEstudiante = asNetControlServicioSocial.ObtenerProyectoEstudiantePorIds(IdProyecto, IdEstudiante);
        }
        catch (Exception)
        {

            throw;
        }
        return proyectoEstudiante;
    }

    public List<ECProyectoEstudiante> ObtenerProyectoEstudiantePorIdEstudiante(int idEstudiante)
    {
        List<ECProyectoEstudiante> lstEcProyectoEstudiante = new List<ECProyectoEstudiante>();
        try
        {
            lstEcProyectoEstudiante = asNetControlServicioSocial.ObtenerProyectoEstudiantePorIdEstudiante(idEstudiante);
        }
        catch (Exception)
        {

            throw;
        }
        return lstEcProyectoEstudiante;
    }

    public void InsertarProyectoEstudiante(int idProyecto, int idEstudiante)
    {
        ECProyectoEstudiante eCProyectoEstudiante = new ECProyectoEstudiante();
        try
        {
            eCProyectoEstudiante.IdProyecto = idProyecto;
            eCProyectoEstudiante.IdEstudiante = idEstudiante;
            eCProyectoEstudiante.HoraAcumulada = 0;
            eCProyectoEstudiante.HoraInicio = DateTime.Now;
            eCProyectoEstudiante.HoraFinal = DateTime.Now;
            eCProyectoEstudiante.LatitudInicial = "0";
            eCProyectoEstudiante.LongitudInicial = "0";
            eCProyectoEstudiante.LatitudFinal = "0";
            eCProyectoEstudiante.LongitudFinal = "0";
            asNetControlServicioSocial.InsertarProyectoEstudiante(eCProyectoEstudiante);
        }
        catch (Exception)
        {

            throw;
        }
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