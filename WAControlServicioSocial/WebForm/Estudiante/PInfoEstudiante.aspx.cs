using SWLNControlServicioSocial;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Estudiante_PInfoEstudiante : System.Web.UI.Page
{
    CEstudiante estudianteService = new CEstudiante();
    CFacultad facultadService = new CFacultad();
    CCertificado certificadoService = new CCertificado();
    CCProyecto proyectoService = new CCProyecto();
    CProyectoEstudiante proyectoEstudianteService = new CProyectoEstudiante();

    private int estudianteId;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (ViewState["estudianteId"] != null)
        {
            estudianteId = (int)ViewState["estudianteId"]; // Recupera el valor del ViewState después de un postback
        }
        if (!IsPostBack)
        {
            Page.ExecuteRegisteredAsyncTasks();
            if (Request.QueryString["estudianteId"] != null && int.TryParse(Request.QueryString["estudianteId"], out estudianteId))
            {
                ECEstudiante estudiante = estudianteService.ObtenerEstudiantePorId_C(estudianteId);
                ECFacultad facultad = facultadService.ObtenerCFacultadPorId_C(estudianteId);

                lblNombreEstudiante.Text = estudiante.NombreEstudiante + " " + estudiante.ApellidoPaternoEstudiante + " " + estudiante.ApellidoMaternoEstudiante;
                lblNombreCarrera.Text = facultad.NombreFacultad;
                lblTiempoContribucion.Text = "0 horas";

                var proyectosEstudiante = proyectoEstudianteService.ObtenerProyectoEstudiantePorIdEstudiante(estudianteId);
                var certificadosEstudiante = certificadoService.ObtenerCertificadosEstudianteC(estudianteId);
                var totalCargaHoraria = certificadosEstudiante.Sum(c => c.CargaHoraria);
                var totalHorasAcumuladas = proyectosEstudiante.Sum(pe => pe.HoraAcumulada) + totalCargaHoraria;
                lblHorasTotales.Text = totalHorasAcumuladas + (totalHorasAcumuladas == 1 ? " hora" : " horas");

                CargarProyectos(estudianteId);
                CargarCertificados(estudianteId);
                InicializarMapa();
            } 
        }
        ViewState["estudianteId"] = estudianteId; // Mover esta línea fuera del bloque if (!IsPostBack)
    }

    private void InicializarMapa()
    {
        double latitudMapa1 = -17.332176;
        double longitudMapa1 = -66.225870;
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
            ECProyectoEstudiante proyectoEstudiante = proyectoEstudianteService.ObtenerProyectoEstudiantePorIds(idProyecto, estudianteId);
            if (proyectoEstudiante.HoraAcumulada == 1)
            {
                lblTiempoContribucion.Text = proyectoEstudiante.HoraAcumulada.ToString() + " hora";
            } else
            {
                lblTiempoContribucion.Text = proyectoEstudiante.HoraAcumulada.ToString() + " horas";
            }
            
            // Coordenadas estáticas para el primer mapa
            double latitudMapa1 = double.Parse(proyectoEstudiante.LatitudInicial);
            double longitudMapa1 = double.Parse(proyectoEstudiante.LongitudInicial);

            // Coordenadas estáticas para el segundo mapa
            double latitudMapa2 = double.Parse(proyectoEstudiante.LatitudFinal);
            double longitudMapa2 = double.Parse(proyectoEstudiante.LongitudFinal);

            // Actualiza las coordenadas en los mapas
            ActualizarMapas(latitudMapa1, longitudMapa1, latitudMapa2, longitudMapa2);
        }
    }

    private void ActualizarMapas(double latitudMapa1, double longitudMapa1, double latitudMapa2, double longitudMapa2)
    {
        string script = String.Format("<script>var latitudMapa1 = {0}; var longitudMapa1 = {1}; var latitudMapa2 = {2}; var longitudMapa2 = {3}; initializeMaps();</script>", latitudMapa1, longitudMapa1, latitudMapa2, longitudMapa2);
        Page.ClientScript.RegisterStartupScript(this.GetType(), "ActualizarMapas", script, false);
    }

    //protected void gridViewCertificadosEstudiante_RowCommand(object sender, GridViewCommandEventArgs e)
    //{
    //    if (e.CommandName == "Descargar")
    //    {
    //        string nombreArchivo = e.CommandArgument.ToString();
    //        string rutaArchivo = Server.MapPath("~/Archivos/" + nombreArchivo + ".pdf");
    //        Response.ContentType = "application/pdf";
    //        Response.AppendHeader("Content-Disposition", "attachment; filename=" + nombreArchivo + ".pdf");
    //        Response.TransmitFile(rutaArchivo);
    //        Response.End();
    //    }
    //}

    protected void gridViewCertificadosEstudiante_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Descargar")
        {
            string fileName = e.CommandArgument.ToString();
            Page.RegisterAsyncTask(new PageAsyncTask(async cancellationToken =>
            {
                var result = await DownloadFile(fileName);

                if (result.Error != null)
                {
                    // Muestra el mensaje de error en el Label
                    Label1.Text = "Error: " + result.Error;
                }
                else
                {
                    // Descarga el archivo directamente
                    await DownloadFileDirectly(result.FileUrl);
                }
            }));
        }
    }

    private async Task DownloadFileDirectly(string fileUrl)
    {
        using (var client = new HttpClient())
        {
            var fileBytes = await client.GetByteArrayAsync(fileUrl);

            // Extrae el nombre del archivo de la URL antes de los parámetros
            var uri = new Uri(fileUrl);
            string fileName = Path.GetFileName(uri.AbsolutePath);

            Response.Clear();
            Response.ContentType = "application/pdf";
            Response.AddHeader("Content-Disposition", "attachment; filename=" + fileName);
            Response.BinaryWrite(fileBytes);
            Response.Flush();
            Response.End();
        }
    }

    public async Task<FileResult> DownloadFile(string fileName)
    {
        // Intenta obtener la URL del archivo fuera del bloque try/catch
        var result = await FirebaseStorageService.GetFile(fileName);
        return result;
    }
}