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
	#endregion
	#region Tabla: Proyecto
	#region insert
	[OperationContract]
	void Insertar_CProyecto_I(ECProyecto eCProyecto);
	#endregion

	#region get all
	[OperationContract]
	List<ECProyecto> Obtener_CProyecto_O();
	#endregion

	#region get 
	[OperationContract]
	List<ECProyecto> Obtener_CProyecto_O_ID(int Idproyecto);
	#endregion
	#region update a proyecto
	[OperationContract]
	void Actualizar_CProyecto_A(ECProyecto eCProyecto);
	#endregion
	#endregion
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
