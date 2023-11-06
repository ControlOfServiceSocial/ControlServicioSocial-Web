using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWADNETControlServicioSocial
{

	[OperationContract]
	string GetData(int value);

	[OperationContract]
	CompositeType GetDataUsingDataContract(CompositeType composite);

	// TODO: agregue aquí sus operaciones de servicio

	#region Tabla: Estudiante
	[OperationContract]
	List<ECEstudiante> Obtener_CEstudiante_O();
    [OperationContract]
    ECEstudiante ObtenerEstudiantePorId(int idEstudiante);

	#endregion

	#region Tabla: Facultad
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
	ECProyectoEstudiante Obtener_CProyectoEstudiante_O_IdProyecto(int IdProyecto);
	[OperationContract]
	ECProyecto Obtener_CProyecto_O_IdProyecto(int IdProyecto);


    [OperationContract]
    List<ECProyecto> Obtener_CProyectoEstudiante_O_CProyecto(int idEstudiante);

    [OperationContract]
    ECSede ObtenerSedeIdProyecto(int IdProyecto);
	[OperationContract]
	ECProyectoEstudiante ObtenerProyectoEstudiantePorIds(int IdProyecto, int IdEstudiante);
}

// Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
[DataContract]
public class CompositeType
{
	bool boolValue = true;
	string stringValue = "Hello ";

	[DataMember]
	public bool BoolValue
	{
		get { return boolValue; }
		set { boolValue = value; }
	}

	[DataMember]
	public string StringValue
	{
		get { return stringValue; }
		set { stringValue = value; }
	}
}
