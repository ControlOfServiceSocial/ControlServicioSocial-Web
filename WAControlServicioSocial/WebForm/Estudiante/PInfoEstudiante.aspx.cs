using SWLNControlServicioSocial;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Estudiante_PInfoEstudiante : System.Web.UI.Page
{
    CEstudiante estudianteService = new CEstudiante();
    CFacultad facultadService = new CFacultad();
    CCertificado certificadoService = new CCertificado();
    CCProyecto proyectoService = new CCProyecto();

    private int estudianteId;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["estudianteId"] != null && int.TryParse(Request.QueryString["estudianteId"], out estudianteId))
            {
                ECEstudiante estudiante = estudianteService.ObtenerEstudiantePorId_C(estudianteId);
                ECFacultad facultad = facultadService.ObtenerCFacultadPorId_C(estudianteId);

                lblNombreEstudiante.Text = estudiante.NombreEstudiante + " " + estudiante.ApellidoPaternoEstudiante + " " + estudiante.ApellidoMaternoEstudiante;
                lblNombreCarrera.Text = facultad.NombreFacultad;

                CargarProyectos(estudianteId);
                CargarCertificados(estudianteId);
                InicializarMapa();
            }
        }
    }

    private void InicializarMapa()
    {
        double latitudMapa1 = -17.384368;
        double longitudMapa1 = -66.135661;
        double latitudMapa2 = -17.332176;
        double longitudMapa2 = -66.225870;

        string script = "<script>var latitudMapa1 = " + latitudMapa1 + "; var longitudMapa1 = " + longitudMapa1 + "; var latitudMapa2 = " + latitudMapa2 + "; var longitudMapa2 = " + longitudMapa2 + ";</script>";

        Page.ClientScript.RegisterStartupScript(this.GetType(), "CoordenadasMapa", script);
    }

    private void CargarCertificados(int idEstudiante)
    {
        gridViewCertificadosEstudiante.DataSource = certificadoService.ObtenerCertificadosEstudianteC(idEstudiante);
        gridViewCertificadosEstudiante.DataBind();
    }

    private void CargarProyectos(int idEstudiante)
    {
        gridViewProyectosEstudiante.DataSource = proyectoService.Obtener_CProyecto_O_CProyecto(idEstudiante);
        gridViewProyectosEstudiante.DataBind();
    }

    protected void GridViewProyectosEstudiante_SelectedIndexChanged(object sender, EventArgs e)
    {
        int rowIndex = gridViewProyectosEstudiante.SelectedIndex;

        if (rowIndex >= 0)
        {
            int idProyecto = (int)gridViewProyectosEstudiante.DataKeys[rowIndex]["IdProyecto"];
            Label1.Text = "IdProyecto seleccionado: " + idProyecto;

            // Coordenadas estáticas para el primer mapa
            double latitudMapa1 = -17.359334;  
            double longitudMapa1 = -66.171867;

            // Coordenadas estáticas para el segundo mapa
            double latitudMapa2 = -17.406050;  
            double longitudMapa2 = -66.140259;

            // Actualiza las coordenadas en los mapas
            ActualizarMapas(latitudMapa1, longitudMapa1, latitudMapa2, longitudMapa2);
        }
    }

    private void ActualizarMapas(double latitudMapa1, double longitudMapa1, double latitudMapa2, double longitudMapa2)
    {
        string script = String.Format("<script>var latitudMapa1 = {0}; var longitudMapa1 = {1}; var latitudMapa2 = {2}; var longitudMapa2 = {3}; initializeMaps();</script>", latitudMapa1, longitudMapa1, latitudMapa2, longitudMapa2);
        Page.ClientScript.RegisterStartupScript(this.GetType(), "ActualizarMapas", script, false);
    }
}