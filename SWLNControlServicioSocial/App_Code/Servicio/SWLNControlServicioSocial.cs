﻿using SWADNETControlServicioSocial;
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

	#region Estudiante
	public List<ECEstudiante> Obtener_CEstudiante_O()
	{
		CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
		List<ECEstudiante> lstEcEstudiante = new List<ECEstudiante>();
		lstEcEstudiante = cControlServicioSocial.Obtener_CEstudiante_O();
		return lstEcEstudiante;
	}
	#endregion
	#region Tabla: Proyecto
	public void Insertar_CProyecto_I(ECProyecto eCProyecto)
	{
		CControlServicioSocial cControlServicioSocial = new CControlServicioSocial();
		cControlServicioSocial.Insertar_CProyecto_I(eCProyecto);
	}
	#endregion
}
