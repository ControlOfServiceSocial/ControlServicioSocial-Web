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
    List<ECProyecto> listProyectos = new List<ECProyecto>();
    CCProyecto cProyecto = new CCProyecto();
    protected void Page_Load(object sender, EventArgs e)
    {
        double latitudMapa1 = -17.384368;
        double longitudMapa1 = -66.135661;
        double latitudMapa2 = -17.332176;
        double longitudMapa2 = -66.225870;
        if (!IsPostBack)
        {
            if (Request.QueryString["estudianteId"] != null)
            {
                int estudianteId = Convert.ToInt32(Request.QueryString["estudianteId"]);
                ECEstudiante estudiante = cEstudiante.ObtenerEstudiantePorId_C(estudianteId);
                ECFacultad facultad = cFacultad.ObtenerCFacultadPorId_C(estudianteId);

                lblNombreEstudiante.Text = estudiante.NombreEstudiante + " " + estudiante.ApellidoPaternoEstudiante + " " + estudiante.ApellidoMaternoEstudiante;
                lblNombreCarrera.Text = facultad.NombreFacultad;
                CargarProyectos(estudianteId);
                CargarCertificados(estudianteId);
            }


            string script = "<script>";
            script += "var latitudMapa1 = " + latitudMapa1.ToString() + ";";
            script += "var longitudMapa1 = " + longitudMapa1.ToString() + ";";
            script += "var latitudMapa2 = " + latitudMapa2.ToString() + ";";
            script += "var longitudMapa2 = " + longitudMapa2.ToString() + ";";
            script += "</script>";

            Page.ClientScript.RegisterStartupScript(this.GetType(), "CoordenadasMapa", script);
        }
    }

    private void CargarCertificados(int idEstudiante)
    {
        gridViewCertificadosEstudiante.DataSource = null;
        listCertificados = cCertificado.ObtenerCertificadosEstudianteC(idEstudiante);
        gridViewCertificadosEstudiante.DataSource = listCertificados;
        gridViewCertificadosEstudiante.DataBind();
    }

    private void CargarProyectos(int idEstudiante)
    {
        gridViewProyectosEstudiante.DataSource= null;
        listProyectos = cProyecto.Obtener_CProyecto_O_CProyecto(idEstudiante);
        gridViewProyectosEstudiante.DataSource = listProyectos;
        gridViewProyectosEstudiante.DataBind();
    }
}