﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SWADNETControlServicioSocial;

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
    #region Metodos Publicos
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

    public ECProyectoEstudiante Obtener_CProyectoEstudiante_O()
    {
        ECProyectoEstudiante eCProyectoEstudiante = new ECProyectoEstudiante();
        try
        {
            eCProyectoEstudiante = swADNETControlServicioSocial.Obtener_CProyectoEstudiante_O();
        }
        catch (Exception)
        {

            throw;
        }
        return eCProyectoEstudiante;
    }

    public List<ECProyectoEstudiante> Obtener_CProyectoEstudiante_O_IdEstudiante(int idEstudiante)
    {
        List<ECProyectoEstudiante> lstECProyectoEstudiante = new List<ECProyectoEstudiante>();
        try
        {
            lstECProyectoEstudiante = swADNETControlServicioSocial.Obtener_CProyectoEstudiante_O_IdEstudiante(idEstudiante).ToList();
        }
        catch (Exception)
        {

            throw;
        }
        return lstECProyectoEstudiante;
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

    public List<ECCertificado> Obtener_CCertificado_O_IdEstudiante(int idEstudiante)
    {
        List<ECCertificado> lstECCertificado = new List<ECCertificado>();
        try
        {
            lstECCertificado = swADNETControlServicioSocial.Obtener_CCertificado_O_IdEstudiante(idEstudiante).ToList();
        }
        catch (Exception)
        {

            throw;
        }
        return lstECCertificado;
    }

    public void Insertar_CCertificado_I(ECCertificado eCCertificado)
    {
        try
        {
            swADNETControlServicioSocial.Insertar_CCertificado_I(eCCertificado);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public void Actualizar_CProyectoEstudiante_A_HoraAcumulada(ECProyectoEstudiante eCProyectoEstudiante)
    {
        try
        {
            swADNETControlServicioSocial.Actualizar_CProyectoEstudiante_A_HoraAcumulada(eCProyectoEstudiante);
        }
        catch (Exception)
        {

            throw;
        }
    }

    public void Actualizar_CProyectoEstudiante_A_Inicio(ECProyectoEstudiante eCProyectoEstudiante)
    {
        try
        {
            swADNETControlServicioSocial.Actualizar_CProyectoEstudiante_A_Inicio(eCProyectoEstudiante);
        }
        catch (Exception)
        {

            throw;
        }
    }
    #endregion
}