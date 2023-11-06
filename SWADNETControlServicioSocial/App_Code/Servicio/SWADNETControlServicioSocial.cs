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
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}

	#region Tabla: Estudiante
	public List<ECEstudiante> Obtener_CEstudiante_O()
    {
        CCEstudiante cCEstudiante = new CCEstudiante();
		List<ECEstudiante> lstCEstudiante = new List<ECEstudiante>();
		lstCEstudiante = cCEstudiante.Obtener_CEstudiante_O();
		return lstCEstudiante;
    }

    public ECEstudiante ObtenerEstudiantePorId(int idEstudiante)
    {
        CCEstudiante cCEstudiante = new CCEstudiante();
        ECEstudiante estudiante = cCEstudiante.ObtenerEstudiantePorId(idEstudiante);

        if (estudiante == null)
        {
            // Puedes lanzar una excepción si el estudiante no se encuentra o devolver un valor por defecto según tus necesidades.
            throw new Exception("Estudiante no encontrado"); // Ejemplo de lanzar una excepción
        }
        return estudiante;
    }

    #endregion

    #region Tabla: Facultad
    public ECFacultad ObtenerCFacultadPorId(int idEstudiante)
    {
        CCFacultad cCFacultad = new CCFacultad();
        ECFacultad facultad = cCFacultad.ObtenerFacultadPorIdEstudiante(idEstudiante);

        if (facultad == null)
        {
            // Puedes lanzar una excepción si el estudiante no se encuentra o devolver un valor por defecto según tus necesidades.
            throw new Exception("facultad no encontrado"); // Ejemplo de lanzar una excepción
        }
        return facultad;
    }
    #endregion

    #region Certificado
    public List<ECCertificado> Obtener_CertificadosEstudiante(int idEstudiante)
    {
        CCCertificado cCCertificado = new CCCertificado();
        List<ECCertificado> lstCertificadosEstudiante = new List<ECCertificado>();
        lstCertificadosEstudiante = cCCertificado.Obtener_CCertificadosEstudiante(idEstudiante);
        return lstCertificadosEstudiante;
    }
    #endregion


    public List<ECCertificado> Obtener_CCertificado_O()
    {
		CCCertificado cCCertificado=new CCCertificado();
		List<ECCertificado> lstCcCertificado=new List<ECCertificado>();
		lstCcCertificado=cCCertificado.Obtener_CCertificado_O();
		return lstCcCertificado;	
    }

    public List<ECProyectoEstudiante> Obtener_CProyectoEstudiante_O()
    {
		CCProyectoEstudiante cCProyectoEstudiante=new CCProyectoEstudiante();
		List<ECProyectoEstudiante> lstCProyectoEstudiante=new List<ECProyectoEstudiante>();
		lstCProyectoEstudiante=cCProyectoEstudiante.Obtener_CProyectoEstudiante_O();
		return lstCProyectoEstudiante;
    }

    public ECProyectoEstudiante Obtener_CProyectoEstudiante_O_IdProyecto(int IdProyecto)
    {
		throw new NotImplementedException();
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

    public List<ECProyecto> Obtener_CProyectoEstudiante_O_CProyecto(int idEstudiante)
    {
        CCProyecto cCProyecto = new CCProyecto();
        List<ECProyecto> lstECProyecto = new List<ECProyecto>();
        lstECProyecto = cCProyecto.Obtener_CProyectoEstudiante_O_CProyecto(idEstudiante);
        return lstECProyecto;
    }

    public ECSede ObtenerSedeIdProyecto(int IdProyecto)
    {
        ECSede eCSede = new ECSede();
        CCSede cCSede = new CCSede();
        eCSede = cCSede.ObtenerSedeIdProyecto(IdProyecto);
        return eCSede;
    }
}
