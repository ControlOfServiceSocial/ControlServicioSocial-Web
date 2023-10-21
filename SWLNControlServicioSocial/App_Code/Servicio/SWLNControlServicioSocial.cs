using SWADNETControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class SWLNControlServicioSocial : ISWLNControlServicioSocial
{
    public List<ECProyecto> Obtener_CProyecto_O()
    {
        CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
        List<ECProyecto> lstECProyectos = new List<ECProyecto>();
        lstECProyectos = cControlServicioSocial.Obtener_CProyecto_O();
        return lstECProyectos; 
    }
}
