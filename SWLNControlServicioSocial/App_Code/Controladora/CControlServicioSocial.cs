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
    #endregion
}