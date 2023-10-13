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
    #endregion

}
