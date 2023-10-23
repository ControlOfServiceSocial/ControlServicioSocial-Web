﻿using SWADNETControlServicioSocial;
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

    public List<ECProyecto> Obtener_CProyecto_O()
    {
        List<ECProyecto> lstEcProyecto=new List<ECProyecto>();
        try
        {
            lstEcProyecto=aSNETControlServicioSocial.Obtener_CProyecto_O();
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
            lstEcCertifiado = aSNETControlServicioSocial.Obtener_CCertificado_O();
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
            lstEcProyectoEstudiante = aSNETControlServicioSocial.Obtener_CProyectoEstudiante_O();
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
            eCProyecto = aSNETControlServicioSocial.Obtener_CProyecto_O_IdProyecto(IdProyecto);
        }
        catch (Exception)
        {

            throw;
        }
        return eCProyecto;
    }
    #endregion
}