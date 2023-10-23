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
    #endregion
    #endregion
}