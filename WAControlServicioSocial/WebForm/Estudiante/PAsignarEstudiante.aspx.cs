using SWLNControlServicioSocial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Estudiante_PAsignarEstudiante : System.Web.UI.Page
{
    CCProyecto cCProyecto = new CCProyecto();
    CEstudiante cCEstudiante = new CEstudiante();
    CProyectoEstudiante cCProyectoEstudiante = new CProyectoEstudiante();

    public string GetNombreCompleto(object dataItem)
    {
        var estudiante = dataItem as ECEstudiante;
        return estudiante.NombreEstudiante + " " + estudiante.ApellidoPaternoEstudiante + " " + estudiante.ApellidoMaternoEstudiante;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string idProyecto = Request.QueryString["idProyecto"];
            ECProyecto eCProyecto = cCProyecto.ObtenerProyectoPorId_C(Convert.ToInt32(idProyecto));
            lblNombreProyecto.Text = eCProyecto.NombreProyecto;
            lblHorasEstimadas.Text = eCProyecto.HorasEstimadas.ToString() + (eCProyecto.HorasEstimadas == 1 ? " hora" : " horas");

            List<ECEstudiante> eCEstudiantes = cCEstudiante.Obtener_CEstudiante_O_CC();
            Repeater1.DataSource = eCEstudiantes;
            Repeater1.DataBind();
        }
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        string estudianteSeleccionado = HiddenField1.Value;

        int IdEstudiante = ConvertirNombreAId(estudianteSeleccionado);

        if (IdEstudiante == 0)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Swal.fire('Advertencia', 'El estudiante ingresado no está registrado.', 'warning');", true);
            return;
        }

        int IdProyecto = Convert.ToInt32(Request.QueryString["idProyecto"]);

        List<ECProyectoEstudiante> proyectosEstudiante = cCProyectoEstudiante.ObtenerProyectoEstudiantePorIdEstudiante(IdEstudiante);

        // Verifica si el proyecto está en la lista
        bool proyectoYaAsignado = proyectosEstudiante.Any(pe => pe.IdProyecto == IdProyecto);

        if (proyectoYaAsignado)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Swal.fire('Error', 'El estudiante ya está asignado a este proyecto.', 'error');", true);
        }
        else
        {
            // Asignar el estudiante al proyecto
            cCProyectoEstudiante.InsertarProyectoEstudiate(IdProyecto, IdEstudiante);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Swal.fire('¡Éxito!', 'Estudiante asignado correctamente.', 'success');", true);
        }
    }

    private int ConvertirNombreAId(string nombreCompleto)
    {
        var estudiante = cCEstudiante.Obtener_CEstudiante_O_CC().FirstOrDefault(e => string.Equals(GetNombreCompleto(e), nombreCompleto, StringComparison.OrdinalIgnoreCase));
        return estudiante != null ? estudiante.IdEstudiante : 0;
    }
}