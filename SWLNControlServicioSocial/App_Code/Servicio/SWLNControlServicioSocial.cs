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
    public List<ECCertificado> Obtener_CCertificado_O()
    {
        CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
        List<ECCertificado> lstECCertificados = new List<ECCertificado>();
        lstECCertificados = cControlServicioSocial.Obtener_CCertificado_O();
        return lstECCertificados;
    }

    public List<ECCertificado> Obtener_CCertificado_O_IdEstudiante(int idEstudiante)
    {
        CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
        List<ECCertificado> lstECCertificados = new List<ECCertificado>();
        lstECCertificados = cControlServicioSocial.Obtener_CCertificado_O_IdEstudiante(idEstudiante);
        return lstECCertificados;
    }

    public ECProyectoEstudiante Obtener_CProyectoEstudiante_O()
    {
        CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
        ECProyectoEstudiante eCProyectoEstudiante = new ECProyectoEstudiante();
        eCProyectoEstudiante = cControlServicioSocial.Obtener_CProyectoEstudiante_O();
        return eCProyectoEstudiante;
    }

    public List<ECProyectoEstudiante> Obtener_CProyectoEstudiante_O_IdEstudiante(int idEstudiante)
    {
        CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
        List<ECProyectoEstudiante> lstECProyectoEstudiante = new List<ECProyectoEstudiante>();
        lstECProyectoEstudiante = cControlServicioSocial.Obtener_CProyectoEstudiante_O_IdEstudiante(idEstudiante);
        return lstECProyectoEstudiante;
    }

    public List<ECProyecto> Obtener_CProyecto_O()
    {
        CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
        List<ECProyecto> lstECProyectos = new List<ECProyecto>();
        lstECProyectos = cControlServicioSocial.Obtener_CProyecto_O();
        return lstECProyectos; 
    }

    public List<ECProyecto> Obtener_CProyecto_O_CProyecto(int idEstudiante)
    {
        CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
        List<ECProyecto> lstECProyectos = new List<ECProyecto>();
        lstECProyectos = cControlServicioSocial.Obtener_CProyecto_O_CProyecto(idEstudiante);
        return lstECProyectos;
    }

    public ECProyecto Obtener_CProyecto_O_IdProyecto(int IdProyecto)
    {
        CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
        ECProyecto eCProyecto = new ECProyecto();
        eCProyecto = cControlServicioSocial.Obtener_CProyecto_O_IdProyecto(IdProyecto);
        return eCProyecto;
    }
}
