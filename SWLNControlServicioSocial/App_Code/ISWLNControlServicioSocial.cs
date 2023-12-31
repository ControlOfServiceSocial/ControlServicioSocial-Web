﻿using SWADNETControlServicioSocial;
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
	[OperationContract]
	void InsertarProyectoEstudiante(int idProyecto, int idEstudiante);

    #region Tabla: Proyecto
    #region insert
    [OperationContract]
    void Insertar_CProyecto_I(string NombreProyecto, string DescripcionProyecto, string UbicacionProyecto, byte EstadoProyecto, string ImagenProyecto, byte HorasEstimadas, DateTime FechaInicioProyecto, DateTime FechaFinProyecto, DateTime FechaCreacionProyecto, int IdSede);
    #endregion

    #region get
    [OperationContract]
    List<ECProyecto> Obtener_CProyecto_O_ID(int Idproyecto);
    #endregion

    #region update
    [OperationContract]
    void Actualizar_CProyecto_A(int IdProyecto, string NombreProyecto, string DescripcionProyecto, string UbicacionProyecto, byte EstadoProyecto, string ImagenProyecto, byte HorasEstimadas, DateTime FechaInicioProyecto, DateTime FechaFinProyecto, DateTime FechaCreacionProyecto, int IdSede);
    #endregion
    #endregion
}

