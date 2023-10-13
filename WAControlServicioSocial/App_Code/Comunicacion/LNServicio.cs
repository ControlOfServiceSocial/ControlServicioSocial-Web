using SWLNControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de LNServicio
/// </summary>
public class LNServicio
{
    #region Variables
    private SWLNControlServicioSocialClient swlnControlServicioSocial;
    #endregion
    public LNServicio()
    {
        swlnControlServicioSocial = new SWLNControlServicioSocialClient();
    }

    #region Metodos Publicos

    #region CEstudiante 
    public List<ECEstudiante> Obtener_CEstudiante_O()
    {
        List<ECEstudiante> lstEcEstudiante = new List<ECEstudiante>();
        try
        {
            lstEcEstudiante = swlnControlServicioSocial.Obtener_CEstudiante_O().ToList();
        }
        catch (Exception)
        {

            throw;
        }

        return lstEcEstudiante;
    }
    #endregion

    #endregion
}