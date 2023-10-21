using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SWLNControlServicioSocial;
/// <summary>
/// Descripción breve de LNServicio
/// </summary>
public class LNServicio
{
    private SWLNControlServicioSocialClient sWLNControlServicioSocialClient;
    public LNServicio()
    {
        sWLNControlServicioSocialClient=new SWLNControlServicioSocialClient();
    }
    public List<ECProyecto> Obtener_CProyecto_O()
    {
        List<ECProyecto> lstECProyectos = new List<ECProyecto>();
        try
        {
            lstECProyectos = sWLNControlServicioSocialClient.Obtener_CProyecto_O().ToList();
        }
        catch (Exception)
        {

            throw;
        }
        return lstECProyectos;
    }
}