using SWLNControlServicioSocial;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Net;

public partial class WebForm_Proyecto_PCrearProyecto : System.Web.UI.Page
{
    CCProyecto cProyecto = new CCProyecto();
    List<ECProyecto> lstECProyecto = new List<ECProyecto>();
    int flag = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["idProyecto"] != null)
            {
                h2Title.InnerText = "Editar proyecto";
                btnSend.Text = "Editar Proyecto";
                Session["EditarProyecto"] = 1;
                lstECProyecto = cProyecto.Obtener_CProyecto_O_CC_ID(int.Parse(Request.QueryString["idProyecto"]));

                foreach (ECProyecto proyecto in lstECProyecto)
                {
                    txtnombre.Text = proyecto.NombreProyecto;
                    ubicacion.Text = proyecto.UbicacionProyecto;
                    inicio.Text = proyecto.FechaInicioProyecto.ToString("yyyy-MM-dd");
                    fin.Text = proyecto.FechaFinProyecto.ToString("yyyy-MM-dd");
                    creacion.Text = proyecto.FechaCreacionProyecto.ToString("yyyy-MM-dd");
                    estado.SelectedIndex = proyecto.EstadoProyecto;
                    horas.Text = proyecto.HorasEstimadas.ToString();
                    desc.Text = proyecto.DescripcionProyecto;
                    if (proyecto.IdSede != 0)
                        sede.SelectedIndex = proyecto.IdSede;

                    Session["flag"] = 1;
                }
            }
        }
    }

    private async Task crearProyectoAsync()
    {
        if (img.HasFile)
        {
            // Verifica si el archivo es una imagen
            string extension = Path.GetExtension(img.FileName);
            if (extension != "")
            {
                string fileName = Path.GetFileName(img.PostedFile.FileName);
                string imageName = Path.GetFileName(img.FileName);

                using (Stream imageStream = img.PostedFile.InputStream)
                {
                    // Llamada al método UploadImage de FireBaseStorageServiceProyecto
                    string fileUrl = await FireBaseStorageServiceProyecto.UploadImage(imageStream, txtnombre.Text + extension);
                }

                try
                {
                    cProyecto.Insertar_CProyecto_I_CC(txtnombre.Text, desc.Text, ubicacion.Text, byte.Parse(estado.SelectedValue), txtnombre.Text + extension, byte.Parse(horas.Text), DateTime.Parse(inicio.Text), DateTime.Parse(fin.Text), DateTime.Parse(creacion.Text), int.Parse(sede.SelectedValue));
                    mensaje.InnerText = "El proyecto se guardo correctamente";
                    Session["EditarProyecto"] = 0;
                    Response.Redirect("PtableroProyecto.aspx");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        else
        {
            mensaje.InnerText = "Debe subir una imagen";
        }
    }

    private async Task actualizarAsync()
    {
        if (img.HasFile)
        {
            // Verifica si el archivo es una imagen
            string extension = Path.GetExtension(img.FileName);
            if (extension != "")
            {
                string fileName = Path.GetFileName(img.PostedFile.FileName);
                string imageName = Path.GetFileName(img.FileName);

                using (Stream imageStream = img.PostedFile.InputStream)
                {
                    // Llamada al método UploadImage de FireBaseStorageServiceProyecto
                    string fileUrl = await FireBaseStorageServiceProyecto.UploadImage(imageStream, imageName + extension);
                }

                try
                {
                    cProyecto.Actualizar_CProyecto_A_CC(int.Parse(Request.QueryString["idProyecto"]), txtnombre.Text, desc.Text, ubicacion.Text, byte.Parse(estado.SelectedValue), imageName + extension, byte.Parse(horas.Text), DateTime.Parse(inicio.Text), DateTime.Parse(fin.Text), DateTime.Parse(creacion.Text), int.Parse(sede.SelectedValue));
                    mensaje.InnerText = "El proyecto se actualizo correctamente";
                    Session["EditarProyecto"] = 0;
                    Response.Redirect("PtableroProyecto.aspx");
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        else
        {
            mensaje.InnerText = "Debe subir una imagen";
        }
    }


    protected async void btnSend_Click(object sender, EventArgs e)
    {
        if (int.Parse(Session["EditarProyecto"].ToString()) > 0)
        {
            await actualizarAsync();
        }
        else
        {
            await crearProyectoAsync();
        }
    }
}