using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CCProyecto
/// </summary>
public class CCProyecto
{
    #region Metodos Privados
    private ADCProyecto aDCProyecto;
    #endregion

    #region Metodos Publicos
    public CCProyecto()
    {
        aDCProyecto = new ADCProyecto();
    }
    #region insert de Proyecto
    public void Insertar_CProyecto_I(ECProyecto eCProyecto)
    {
        aDCProyecto.Insertar_CProyecto_I(eCProyecto);
    }
    #endregion

    #region get de todos los proyectos
    public List<ECProyecto> Obtener_CProyecto_O()
    {
        ECProyecto eCProyecto;
        List<ECProyecto> lstECProyecto = new List<ECProyecto>();
        DTOCProyecto dtoCProyecto = aDCProyecto.Obtener_CProyecto_O();
        if (dtoCProyecto != null)
        {
            foreach (DTOCProyecto.CProyectoRow drCProyecto in dtoCProyecto.CProyecto.Rows)
            {
                eCProyecto = new ECProyecto();
                eCProyecto.IdProyecto = drCProyecto.IdProyecto;
                eCProyecto.NombreProyecto = drCProyecto.NombreProyecto.TrimEnd();
                eCProyecto.DescripcionProyecto = drCProyecto.DescripcionProyecto.TrimEnd();
                eCProyecto.UbicacionProyecto = drCProyecto.UbicacionProyecto.TrimEnd();
                eCProyecto.EstadoProyecto = drCProyecto.EstadoProyecto;
                eCProyecto.ImagenProyecto = drCProyecto.ImagenProyecto;
                eCProyecto.HorasEstimadas = drCProyecto.HorasEstimadas;
                eCProyecto.FechaInicioProyecto = drCProyecto.FechaInicioProyecto;
                eCProyecto.FechaFinProyecto = drCProyecto.FechaFinProyecto;
                eCProyecto.FechaCreacionProyecto = drCProyecto.FechaCreacionProyecto;
                lstECProyecto.Add(eCProyecto);
            }
        }
        else
        {
            dtoCProyecto = new DTOCProyecto();
        }

        return lstECProyecto;
    }
    #endregion

    #region get de un proyecto
    public List<ECProyecto> Obtener_CProyecto_O_ID(int Idproyecto)
    {
        ECProyecto eCProyecto;
        List<ECProyecto> lstECProyecto = new List<ECProyecto>();
        DTOCProyecto dtoCProyecto = aDCProyecto.Obtener_CProyecto_O_ID(Idproyecto);
        if (dtoCProyecto != null)
        {
            foreach (DTOCProyecto.CProyectoRow drCProyecto in dtoCProyecto.CProyecto.Rows)
            {
                eCProyecto = new ECProyecto();
                eCProyecto.IdProyecto = drCProyecto.IdProyecto;
                eCProyecto.NombreProyecto = drCProyecto.NombreProyecto.TrimEnd();
                eCProyecto.DescripcionProyecto = drCProyecto.DescripcionProyecto.TrimEnd();
                eCProyecto.UbicacionProyecto = drCProyecto.UbicacionProyecto.TrimEnd();
                eCProyecto.EstadoProyecto = drCProyecto.EstadoProyecto;
                eCProyecto.ImagenProyecto = drCProyecto.ImagenProyecto;
                eCProyecto.HorasEstimadas = drCProyecto.HorasEstimadas;
                eCProyecto.FechaInicioProyecto = drCProyecto.FechaInicioProyecto;
                eCProyecto.FechaFinProyecto = drCProyecto.FechaFinProyecto;
                eCProyecto.FechaCreacionProyecto = drCProyecto.FechaCreacionProyecto;
                eCProyecto.IdSede = drCProyecto.IdSede;
                lstECProyecto.Add(eCProyecto);
            }
        }
        else
        {
            dtoCProyecto = new DTOCProyecto();
        }

        return lstECProyecto;
    }
    #endregion
    #region update a proyecto
    public void Actualizar_CProyecto_A(ECProyecto eCProyecto)
    {
        aDCProyecto.Actualizar_CProyecto_A(eCProyecto);
    }
    #endregion

    #endregion
}