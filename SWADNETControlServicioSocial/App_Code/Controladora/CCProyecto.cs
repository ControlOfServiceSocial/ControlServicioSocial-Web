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
    public List<ECProyecto> Obtener_CProyecto_O()
    {
        ECProyecto eCProyecto;
        List<ECProyecto> lstECProyecto=new List<ECProyecto>();
        DTOCProyecto dTOCProyecto = aDCProyecto.Obtener_CProyecto_O();
        if (dTOCProyecto==null)
        {
            foreach (DTOCProyecto.CProyectoRow drCProyecto in dTOCProyecto.CProyecto.Rows)
            {
                eCProyecto = new ECProyecto();
                eCProyecto.IdProyecto = drCProyecto.IdProyecto;
                eCProyecto.NombreProyecto = drCProyecto.NombreProyecto;
                eCProyecto.DescripcionProyecto = drCProyecto.DescripcionProyecto;
                eCProyecto.UbicacionProyecto = drCProyecto.UbicacionProyecto;
                eCProyecto.EstadoProyecto = drCProyecto.EstadoProyecto;
                eCProyecto.ImagenProyecto = drCProyecto.ImagenProyecto;
                eCProyecto.HorasEstimadas = drCProyecto.HorasEstimadas;
                eCProyecto.FechaInicioProyecto = drCProyecto.FechaInicioProyecto;
                eCProyecto.FechaFinProyecto = drCProyecto.FechaFinProyecto;
                eCProyecto.FechaCreacionProyecto = drCProyecto.FechaCreacionProyecto;

            }
        }
        else
        {
            dTOCProyecto=new DTOCProyecto();
        }
        return lstECProyecto;
    }
    #endregion

}