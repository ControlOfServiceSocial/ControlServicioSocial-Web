﻿using SWADNETControlServicioSocial;
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

    public List<ECProyecto> Obtener_CProyecto_O()
    {
        List<ECProyecto> lstEcProyecto = new List<ECProyecto>();
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

    #endregion
    #endregion

}