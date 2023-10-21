using SWLNControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Descripción breve de CEstudiante
/// </summary>
public class CEstudiante : System.Web.UI.Page
{
    LNServicio lnServicio = new LNServicio();
    public CEstudiante()
    {
        
    }

    public List<ECEstudiante> Obtener_CEstudiante_O_CC()
    {
        List<ECEstudiante> lstEcEstudiante = new List<ECEstudiante>();
        try
        {
            lstEcEstudiante = lnServicio.Obtener_CEstudiante_O().ToList();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return lstEcEstudiante;
    }
}