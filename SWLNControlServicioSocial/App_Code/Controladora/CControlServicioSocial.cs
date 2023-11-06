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

    #endregion
}