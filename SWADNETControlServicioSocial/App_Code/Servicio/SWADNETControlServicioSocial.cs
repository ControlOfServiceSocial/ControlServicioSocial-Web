using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class SWADNETControlServicioSocial : ISWADNETControlServicioSocial
{
    public List<ECCertificado> Obtener_CCertificado_O()
    {
		CCCertificado cCCertificado=new CCCertificado();
		List<ECCertificado> lstCcCertificado=new List<ECCertificado>();
		lstCcCertificado=cCCertificado.Obtener_CCertificado_O();
		return lstCcCertificado;	
    }

    public ECProyectoEstudiante Obtener_CProyectoEstudiante_O()
    {
		CCProyectoEstudiante cCProyectoEstudiante=new CCProyectoEstudiante();
		ECProyectoEstudiante eCProyectoEstudiante=new ECProyectoEstudiante();
		eCProyectoEstudiante=cCProyectoEstudiante.Obtener_CProyectoEstudiante_O();
		return eCProyectoEstudiante;
    }

    public List<ECProyecto> Obtener_CProyectoEstudiante_O_CProyecto(int idEstudiante)
    {
		CCProyecto cCProyecto=new CCProyecto();
		List<ECProyecto> lstECProyecto=new List<ECProyecto>();
		lstECProyecto=cCProyecto.Obtener_CProyectoEstudiante_O_CProyecto(idEstudiante);
		return lstECProyecto;
    }

    public List<ECProyectoEstudiante> Obtener_CProyectoEstudiante_O_IdEstudiante(int idEstudiante)
    {
		CCProyectoEstudiante cCProyectoEstudiante=new CCProyectoEstudiante();
		List<ECProyectoEstudiante> lstECProyectoEstudiante=new List<ECProyectoEstudiante>();
		lstECProyectoEstudiante=cCProyectoEstudiante.Obtener_CProyectoEstudiante_O_IdEstudiante(idEstudiante);
		return lstECProyectoEstudiante;
    }
    public List<ECProyecto> Obtener_CProyecto_O()
    {
        CCProyecto cCProyecto = new CCProyecto();
		List<ECProyecto> lstCProyecto=new List<ECProyecto>();
		lstCProyecto=cCProyecto.Obtener_CProyecto_O();
		return lstCProyecto;
    }

    public ECProyecto Obtener_CProyecto_O_IdProyecto(int IdProyecto)
    {
        ECProyecto eCProyecto = new ECProyecto();
		CCProyecto cCProyecto = new CCProyecto();
		eCProyecto=cCProyecto.Obtener_CProyecto_O_IdProyecto(IdProyecto);
		return eCProyecto;
    }
}
