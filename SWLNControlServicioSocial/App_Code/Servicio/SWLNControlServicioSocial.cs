using SWADNETControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Policy;
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

	#region Estudiante
	public List<ECEstudiante> Obtener_CEstudiante_O()
	{
		CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
		List<ECEstudiante> lstEcEstudiante = new List<ECEstudiante>();
		lstEcEstudiante = cControlServicioSocial.Obtener_CEstudiante_O();
		return lstEcEstudiante;
	}

    public ECEstudiante ObtenerEstudiantePorId(int idEstudiante)
    {
        CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
        ECEstudiante eCEstudiante = new ECEstudiante();
        eCEstudiante = cControlServicioSocial.ObtenerEstudiantePorId(idEstudiante);
        return eCEstudiante;
    }
    #endregion

    #region Facultad
    public ECFacultad ObtenerCFacultadPorId(int idEstudiante)
    {
        CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
        ECFacultad eCFacultad = new ECFacultad();
        eCFacultad = cControlServicioSocial.ObtenerCFacultadPorId(idEstudiante);
        return eCFacultad;
    }
    #endregion

    #region Certificado
    public List<ECCertificado> Obtener_CertificadosEstudiante(int idEstudiante)
    {
        CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
        List<ECCertificado> lstECertificadosEstudiante = new List<ECCertificado>();
        lstECertificadosEstudiante = cControlServicioSocial.ObtenerCertificadosEstudiante(idEstudiante);
        return lstECertificadosEstudiante;
    }
    #endregion

    public List<ECProyectoEstudiante> Obtener_CProyectoEstudiante_O()
    {
        CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
        List<ECProyectoEstudiante> lstECProyectoEstudiante = new List<ECProyectoEstudiante>();
        lstECProyectoEstudiante = cControlServicioSocial.Obtener_CProyectoEstudiante_O();
        return lstECProyectoEstudiante;
    }

    public List<ECProyecto> Obtener_CProyecto_O()
    {
        CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
        List<ECProyecto> lstECProyectos = new List<ECProyecto>();
        lstECProyectos = cControlServicioSocial.Obtener_CProyecto_O();
        return lstECProyectos; 
    }

    public ECProyecto Obtener_CProyecto_O_IdProyecto(int IdProyecto)
    {
        CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
        ECProyecto eCProyecto = new ECProyecto();
        eCProyecto = cControlServicioSocial.Obtener_CProyecto_O_IdProyecto(IdProyecto);
        return eCProyecto;
    }

    public List<ECProyecto> Obtener_CProyecto_O_CProyecto(int idEstudiante)
    {
        CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
        List<ECProyecto> lstECProyectos = new List<ECProyecto>();
        lstECProyectos = cControlServicioSocial.Obtener_CProyecto_O_CProyecto(idEstudiante);
        return lstECProyectos;
    }

    public ECSede ObtenerSedeIdProyecto(int IdProyecto)
    {
        CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
        ECSede eCSede = new ECSede();
        eCSede = cControlServicioSocial.ObtenerSedeIdProyecto(IdProyecto);
        return eCSede;
    }

    public ECProyectoEstudiante ObtenerProyectoEstudiantePorIds(int IdProyecto, int IdEstudiante)
    {
        CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
        ECProyectoEstudiante eCProyectoEstudiante = new ECProyectoEstudiante();
        eCProyectoEstudiante = cControlServicioSocial.ObtenerProyectoEstudiantePorIds(IdProyecto, IdEstudiante);
        return eCProyectoEstudiante;
    }

    public List<ECProyectoEstudiante> ObtenerProyectoEstudiantePorIdEstudiante(int idEstudiante)
    {
        CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
        List<ECProyectoEstudiante> lstECProyectoEstudiante = new List<ECProyectoEstudiante>();
        lstECProyectoEstudiante = cControlServicioSocial.ObtenerProyectoEstudiantePorIdEstudiante(idEstudiante);
        return lstECProyectoEstudiante;
    }
}
