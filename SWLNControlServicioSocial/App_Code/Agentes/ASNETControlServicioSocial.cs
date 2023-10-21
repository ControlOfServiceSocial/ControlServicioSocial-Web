using SWADNETControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using SWADNETControlServicioSocial;

/// <summary>
/// Descripción breve de ASNETControlServicioSocial
/// </summary>
public class ASNETControlServicioSocial
{
    #region
    private SWADNETControlServicioSocialClient swADNETControlServicioSocial;
    #endregion
    public ASNETControlServicioSocial()
    {
        swADNETControlServicioSocial = new SWADNETControlServicioSocialClient();
    }

    #region Metodos publicos

    #region CEstudiante
    public List<ECEstudiante> Obtener_CEstudiante_O()
    {
        List<ECEstudiante> lstEcEstudiante = new List<ECEstudiante>();
        try
        {
            lstEcEstudiante = swADNETControlServicioSocial.Obtener_CEstudiante_O().ToList();
        }
        catch (Exception)
        {

            throw;
        }

        return lstEcEstudiante;
    }
    #endregion
    #region CProyecto
    public void Insertar_CProyecto_I(ECProyecto eCProyecto)
    {
        /*try
        {
            swADNETControlServicioSocial.(eRCampania);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            ECProyecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_RCampania_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                swADNETReciclado.Insertar_RCampania_I(eRCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_RCampania_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }*/
    }
    #endregion
    #endregion

}