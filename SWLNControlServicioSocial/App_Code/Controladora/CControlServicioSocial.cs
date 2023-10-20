using SWADNETControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de CControlServicioSocial
/// </summary>
public class CControlServicioSocial
{
    ASNETControlServicioSocial aSNETControlServicioSocial;
    public CControlServicioSocial()
    {
        aSNETControlServicioSocial = new ASNETControlServicioSocial();
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
}