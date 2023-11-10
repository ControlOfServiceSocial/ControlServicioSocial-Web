using SWADNETControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;


/// <summary>
/// Descripción breve de ASNETControlServicioSocial
/// </summary>
public class ASNETControlServicioSocial
{
    #region
    private SWADNETControlServicioSocialClient swADNETControlServicioSocial;
    #endregion
    public ASNETControlServicioSocial()
    {
        swADNETControlServicioSocial = new SWADNETControlServicioSocialClient();
    }

    #region Metodos publicos

    #region CEstudiante
    public List<ECEstudiante> Obtener_CEstudiante_O()
    {
        List<ECEstudiante> lstEcEstudiante = new List<ECEstudiante>();
        try
        {
            lstEcEstudiante = swADNETControlServicioSocial.Obtener_CEstudiante_O().ToList();
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
            estudiante = swADNETControlServicioSocial.ObtenerEstudiantePorId(idEstudiante);
        }
        catch (Exception)
        {
            // Manejar excepciones aquí
            throw;
        }
        return estudiante;
    }

    #endregion

    #region CFacultad

    public ECFacultad ObtenerCFacultadPorId(int idEstudiante)
    {
        ECFacultad facultad = new ECFacultad();
        try
        {
            facultad = swADNETControlServicioSocial.ObtenerCFacultadPorId(idEstudiante);
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
            lstCertificadosEstudiante = swADNETControlServicioSocial.Obtener_CertificadosEstudiante(idEstudiante).ToList();
        }
        catch (Exception)
        {
            throw;
        }
        return lstCertificadosEstudiante;
    }
    #endregion

    #region CProyecto
    public List<ECProyecto> Obtener_CProyecto_O()
    {
        List<ECProyecto>lstEcProyecto=new List<ECProyecto>();
        try
        {
            lstEcProyecto = swADNETControlServicioSocial.Obtener_CProyecto_O().ToList();
        }
        catch (Exception)
        {

            throw;
        }
        return lstEcProyecto;
    }
    public List<ECCertificado> Obtener_CCertificado_O()
    {
        List<ECCertificado>lstEcCertifiado=new List<ECCertificado>();
        try
        {
            lstEcCertifiado = swADNETControlServicioSocial.Obtener_CCertificado_O().ToList();
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
            lstEcProyectoEstudiante = swADNETControlServicioSocial.Obtener_CProyectoEstudiante_O().ToList();
        }
        catch (Exception)
        {

            throw;
        }
        return lstEcProyectoEstudiante;
    }
    public ECProyecto Obtener_CProyecto_O_IdProyecto(int IdProyecto)
    {
        ECProyecto eCProyecto = new ECProyecto();
        try
        {
            eCProyecto = swADNETControlServicioSocial.Obtener_CProyecto_O_IdProyecto(IdProyecto);
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
            lstECProyecto = swADNETControlServicioSocial.Obtener_CProyectoEstudiante_O_CProyecto(idEstudiante).ToList();
        }
        catch (Exception)
        {

            throw;
        }
        return lstECProyecto;
    }
    #endregion

    #region Sede
    public ECSede ObtenerSedeIdProyecto(int idProyecto)
    {
        ECSede sede = new ECSede();
        try
        {
            sede = swADNETControlServicioSocial.ObtenerSedeIdProyecto(idProyecto);
        }
        catch (Exception)
        {

            throw;
        }
        return sede;
    }
    #endregion

    #region ProyectoEstudiante
    public ECProyectoEstudiante ObtenerProyectoEstudiantePorIds(int IdProyecto, int IdEstudiante)
    {
        ECProyectoEstudiante proyectoEstudiante = new ECProyectoEstudiante();
        try
        {
            proyectoEstudiante = swADNETControlServicioSocial.ObtenerProyectoEstudiantePorIds(IdProyecto, IdEstudiante);
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
            lstEcProyectoEstudiante = swADNETControlServicioSocial.ObtenerProyectoEstudiantePorIdEstudiante(idEstudiante).ToList();
        }
        catch (Exception)
        {

            throw;
        }
        return lstEcProyectoEstudiante;
    }

    public void InsertarProyectoEstudiante(ECProyectoEstudiante eCProyectoEstudiante)
    {
        try
        {
            swADNETControlServicioSocial.InsertarProyectoEstudiante(eCProyectoEstudiante);
        }
        catch (Exception)
        {

            throw;
        }
    }
    #endregion
    #endregion

    #region CProyecto
    #region insert
    public void Insertar_CProyecto_I(ECProyecto eCProyecto)
    {
        try
        {
            swADNETControlServicioSocial.Insertar_CProyecto_I(eCProyecto);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            /*EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_RCampania_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);*/
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                swADNETControlServicioSocial.Insertar_CProyecto_I(eCProyecto);
            }
            else
            {
                /*EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_RCampania_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);*/
            }

        }
    }
    #endregion

    #region get
    public List<ECProyecto> Obtener_CProyecto_O_ID(int Idproyecto)
    {
        List<ECProyecto> lstEcProyecto = new List<ECProyecto>();
        try
        {
            lstEcProyecto = swADNETControlServicioSocial.Obtener_CProyecto_O_ID(Idproyecto).ToList();
        }
        catch (Exception)
        {

            throw;
        }

        return lstEcProyecto;
    }
    #endregion

    #region update
    public void Actualizar_CProyecto_A(ECProyecto eCProyecto)
    {
        try
        {
            swADNETControlServicioSocial.Actualizar_CProyecto_A(eCProyecto);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            /*EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_RCampania_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);*/
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                swADNETControlServicioSocial.Actualizar_CProyecto_A(eCProyecto);
            }
            else
            {
                /*EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_RCampania_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);*/
            }

        }
    }
    #endregion
    #endregion
}