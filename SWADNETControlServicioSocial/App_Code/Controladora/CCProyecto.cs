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

    public void Insertar_CProyecto_I(ECProyecto eCProyecto)
    {
        aDCProyecto.Insertar_CProyecto_I(eCProyecto);
    }

    #endregion
}