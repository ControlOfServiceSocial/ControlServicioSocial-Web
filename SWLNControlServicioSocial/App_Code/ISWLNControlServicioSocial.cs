using SWADNETControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWLNControlServicioSocial
{
	// TODO: agregue aquí sus operaciones de servicio

	#region Estudiante
	[OperationContract]
	List<ECEstudiante> Obtener_CEstudiante_O();

    [OperationContract]
    ECEstudiante ObtenerEstudiantePorId(int idEstudiante);
	#endregion

	#region Facultad
	[OperationContract]
	ECFacultad ObtenerCFacultadPorId(int idEstudiante);
	#endregion

	#region Certificado
	[OperationContract]
	List<ECCertificado> Obtener_CertificadosEstudiante(int idEstudiante);
    #endregion

    [OperationContract]
	List<ECProyecto> Obtener_CProyecto_O();
	[OperationContract]
	List<ECCertificado> Obtener_CCertificado_O();
	[OperationContract]
	List<ECProyectoEstudiante> Obtener_CProyectoEstudiante_O();
	[OperationContract]
	ECProyecto Obtener_CProyecto_O_IdProyecto(int IdProyecto);

    [OperationContract]
    List<ECProyecto> Obtener_CProyecto_O_CProyecto(int idEstudiante);
    [OperationContract]
    ECSede ObtenerSedeIdProyecto(int IdProyecto);

	[OperationContract]
	ECProyectoEstudiante ObtenerProyectoEstudiantePorIds(int IdProyecto, int IdEstudiante);
	[OperationContract]
	List<ECProyectoEstudiante> ObtenerProyectoEstudiantePorIdEstudiante(int IdEstudiante);
}

