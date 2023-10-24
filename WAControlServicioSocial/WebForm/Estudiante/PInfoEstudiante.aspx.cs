using SWLNControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Estudiante_PInfoEstudiante : System.Web.UI.Page
{
    CEstudiante cEstudiante = new CEstudiante();
    CFacultad cFacultad = new CFacultad();
    List<ECCertificado> listCertificados = new List<ECCertificado>();
    CCertificado cCertificado = new CCertificado();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["estudianteId"] != null)
            {
                int estudianteId = Convert.ToInt32(Request.QueryString["estudianteId"]);
                // Utiliza estudianteId para obtener la información del estudiante
                ECEstudiante estudiante = cEstudiante.ObtenerEstudiantePorId_C(estudianteId);
                ECFacultad facultad = cFacultad.ObtenerCFacultadPorId_C(estudianteId);
                // Asigna la información del estudiante a los controles de la página, como lblNombreEstudiante
                lblNombreEstudiante.Text = estudiante.NombreEstudiante + " " + estudiante.ApellidoPaternoEstudiante + " " + estudiante.ApellidoMaternoEstudiante;
                // Resto de asignaciones de información
                lblNombreCarrera.Text = facultad.NombreFacultad;
                CargarDatos(estudianteId);

                // Puedes cargar otros datos relacionados con el estudiante en esta página
            }
        }
    }

    private void CargarDatos(int idEstudiante)
    {
        gridViewCertificadosEstudiante.DataSource = null;
        listCertificados = cCertificado.ObtenerCertificadosEstudianteC(idEstudiante);
        gridViewCertificadosEstudiante.DataSource = listCertificados;
        gridViewCertificadosEstudiante.DataBind();
    }
}