using SWLNControlServicioSocial;
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

    public void Insertar_CProyecto_I(ECProyecto eCProyecto)
    {     
        try
        {
            lnServicio.Insertar_CProyecto_I(eCProyecto);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}