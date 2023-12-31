﻿using SWLNControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CProyecto
/// </summary>
public class CProyecto : System.Web.UI.Page
{
    LNServicio lnServicio = new LNServicio();

    public CProyecto()
    {
        
    }
    #region insert
    public void Insertar_CProyecto_I_CC(string NombreProyecto, string DescripcionProyecto, string UbicacionProyecto, byte EstadoProyecto, string ImagenProyecto, byte HorasEstimadas, DateTime FechaInicioProyecto, DateTime FechaFinProyecto, DateTime FechaCreacionProyecto, int IdSede)
    {
        try
        {
            lnServicio.Insertar_CProyecto_I(NombreProyecto, DescripcionProyecto, UbicacionProyecto, EstadoProyecto, ImagenProyecto, HorasEstimadas, FechaInicioProyecto, FechaFinProyecto, FechaCreacionProyecto, IdSede);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion

    #region get all
    public List<ECProyecto> Obtener_CProyecto_O_CC()
    {
        List<ECProyecto> lstEcProyecto = new List<ECProyecto>();
        try
        {
            lstEcProyecto = lnServicio.Obtener_CProyecto_O().ToList();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return lstEcProyecto;
    }
    #endregion

    #region get
    public List<ECProyecto> Obtener_CProyecto_O_CC_ID(int Idproyecto)
    {
        List<ECProyecto> lstEcProyecto = new List<ECProyecto>();
        try
        {
            lstEcProyecto = lnServicio.Obtener_CProyecto_O_ID(Idproyecto).ToList();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return lstEcProyecto;
    }
    #endregion

    #region update
    public void Actualizar_CProyecto_A_CC(int IdProyecto, string NombreProyecto, string DescripcionProyecto, string UbicacionProyecto, byte EstadoProyecto, string ImagenProyecto, byte HorasEstimadas, DateTime FechaInicioProyecto, DateTime FechaFinProyecto, DateTime FechaCreacionProyecto, int IdSede)
    {
        try
        {
            lnServicio.Actualizar_CProyecto_A(IdProyecto, NombreProyecto, DescripcionProyecto, UbicacionProyecto, EstadoProyecto, ImagenProyecto, HorasEstimadas, FechaInicioProyecto, FechaFinProyecto, FechaCreacionProyecto, IdSede);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}
