using SWADNETControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWLNControlServicioSocial
{
    [OperationContract]
    List<ECProyecto> Obtener_CProyecto_O();
    [OperationContract]
    List<ECCertificado> Obtener_CCertificado_O();
    [OperationContract]
    List<ECProyectoEstudiante> Obtener_CProyectoEstudiante_O_IdEstudiante(int idEstudiante);
    [OperationContract]
    ECProyectoEstudiante Obtener_CProyectoEstudiante_O();
    [OperationContract]
    ECProyecto Obtener_CProyecto_O_IdProyecto(int IdProyecto);
    [OperationContract]
    List<ECProyecto> Obtener_CProyecto_O_CProyecto(int idEstudiante);
    [OperationContract]
    List<ECCertificado> Obtener_CCertificado_O_IdEstudiante(int idEstudiante);
}

