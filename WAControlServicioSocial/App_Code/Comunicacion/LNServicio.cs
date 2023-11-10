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

    public ECEstudiante ObtenerEstudiantePorId(int idEstudiante)
    {
        ECEstudiante estudiante = new ECEstudiante();
        try
        {
            estudiante = swlnControlServicioSocial.ObtenerEstudiantePorId(idEstudiante);
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
            facultad = swlnControlServicioSocial.ObtenerCFacultadPorId(idEstudiante);
        }
        catch (Exception)
        {
            // Manejar excepciones aquí
            throw;
        }
        return facultad;
    }
    #endregion

    #region Certificado
    public List<ECCertificado> ObtenerCertificadosEstudiante(int idEstudiante)
    {
        List<ECCertificado> lstCertificadosEstudiante = new List<ECCertificado>();
        try
        {
            lstCertificadosEstudiante = swlnControlServicioSocial.Obtener_CertificadosEstudiante(idEstudiante).ToList();
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
        List<ECProyecto> lstECProyectos = new List<ECProyecto>();
        try
        {
            lstECProyectos = swlnControlServicioSocial.Obtener_CProyecto_O().ToList();
        }
        catch (Exception)
        {

            throw;
        }
        return lstECProyectos;
    }

    public List<ECProyecto> Obtener_CProyecto_O_CProyecto(int idEstudiante)
    {
        List<ECProyecto> lstECProyecto = new List<ECProyecto>();
        try
        {
            lstECProyecto = swlnControlServicioSocial.Obtener_CProyecto_O_CProyecto(idEstudiante).ToList();
        }
        catch (Exception)
        {

            throw;
        }
        return lstECProyecto;
    }

    public ECProyecto ObtenerProyectoPorId(int idProyecto)
    {
        ECProyecto proyecto = new ECProyecto();
        try
        {
            proyecto = swlnControlServicioSocial.Obtener_CProyecto_O_IdProyecto(idProyecto);
        }
        catch (Exception)
        {
            // Manejar excepciones aquí
            throw;
        }
        return proyecto;
    }

    public ECSede ObtenerSedeIdProyecto(int idProyecto)
    {
        ECSede sede = new ECSede();
        try
        {
            sede = swlnControlServicioSocial.ObtenerSedeIdProyecto(idProyecto);
        }
        catch (Exception)
        {

            throw;
        }
        return sede;
    }

    public ECProyectoEstudiante ObtenerProyectoEstudiantePorIds(int IdProyecto, int IdEstudiante)
    {
        ECProyectoEstudiante eCProyectoEstudiante = new ECProyectoEstudiante();
        try
        {
            eCProyectoEstudiante = swlnControlServicioSocial.ObtenerProyectoEstudiantePorIds(IdProyecto, IdEstudiante);
        }
        catch (Exception)
        {

            throw;
        }
        return eCProyectoEstudiante;
    }

    public List<ECProyectoEstudiante> ObtenerProyectoEstudiantePorIdEstudiante(int idEstudiante)
    {
        List<ECProyectoEstudiante> lstECProyectoEstudiantes = new List<ECProyectoEstudiante>();
        try
        {
            lstECProyectoEstudiantes = swlnControlServicioSocial.ObtenerProyectoEstudiantePorIdEstudiante(idEstudiante).ToList();
        }
        catch (Exception)
        {

            throw;
        }
        return lstECProyectoEstudiantes;
    }

    public void InsertarProyectoEstudiante(int idProyecto, int idEstudiante)
    {
        try
        {
            swlnControlServicioSocial.InsertarProyectoEstudiante(idProyecto, idEstudiante);
        }
        catch (Exception)
        {

            throw;
        }
    }
    #endregion

    #region CProyecto
    #region insert
    public void Insertar_CProyecto_I(string NombreProyecto, string DescripcionProyecto, string UbicacionProyecto, byte EstadoProyecto, string ImagenProyecto, byte HorasEstimadas, DateTime FechaInicioProyecto, DateTime FechaFinProyecto, DateTime FechaCreacionProyecto, int IdSede)
    {
        try
        {
            swlnControlServicioSocial.Insertar_CProyecto_I(NombreProyecto, DescripcionProyecto, UbicacionProyecto, EstadoProyecto, ImagenProyecto, HorasEstimadas, FechaInicioProyecto, FechaFinProyecto, FechaCreacionProyecto, IdSede);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region get
    public List<ECProyecto> Obtener_CProyecto_O_ID(int Idproyecto)
    {
        List<ECProyecto> lstEcProyecto = new List<ECProyecto>();
        try
        {
            lstEcProyecto = swlnControlServicioSocial.Obtener_CProyecto_O_ID(Idproyecto).ToList();
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
        try
        {
            swlnControlServicioSocial.Actualizar_CProyecto_A(IdProyecto, NombreProyecto, DescripcionProyecto, UbicacionProyecto, EstadoProyecto, ImagenProyecto, HorasEstimadas, FechaInicioProyecto, FechaFinProyecto, FechaCreacionProyecto, IdSede);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #endregion
}