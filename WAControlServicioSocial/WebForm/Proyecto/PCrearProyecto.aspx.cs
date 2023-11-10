using SWLNControlServicioSocial;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Proyecto_PCrearProyecto : System.Web.UI.Page
{
    CCProyecto cProyecto = new CCProyecto();
    List<ECProyecto> lstECProyecto = new List<ECProyecto>();
    int flag = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (int.Parse(Session["flag"].ToString()) == 0)
        {
            if (int.Parse(Session["EditarProyecto"].ToString()) > 0)
            {
                lstECProyecto = cProyecto.Obtener_CProyecto_O_CC_ID(int.Parse(Session["EditarProyecto"].ToString()));

                foreach (ECProyecto proyecto in lstECProyecto)
                {
                    txtnombre.Text = proyecto.NombreProyecto;
                    ubicacion.Text = proyecto.UbicacionProyecto;
                    inicio.Text = proyecto.FechaInicioProyecto.ToString();
                    fin.Text = proyecto.FechaFinProyecto.ToString();
                    creacion.Text = proyecto.FechaCreacionProyecto.ToString();
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

    private void crearProyecto()
    {
        if (img.HasFile)
        {
            // Verifica si el archivo es una imagen
            string extension = Path.GetExtension(img.FileName);
            if (extension != "")
            {
                string fileName = Path.GetFileName(img.PostedFile.FileName);
                string filePath = Server.MapPath("../../Imagenes/Proyecto/") + txtnombre.Text + ".jpg";
                img.SaveAs(filePath);

                string rutaImagen = txtnombre.Text + ".jpg";
                try
                {
                    cProyecto.Insertar_CProyecto_I_CC(txtnombre.Text, desc.Text, ubicacion.Text, byte.Parse(estado.SelectedValue), rutaImagen, byte.Parse(horas.Text), DateTime.Parse(inicio.Text), DateTime.Parse(fin.Text), DateTime.Parse(creacion.Text), int.Parse(sede.SelectedValue));
                    mensaje.InnerText = "El proyecto se guardo correctamente";
                    Session["EditarProyecto"] = 0;
                    Response.Redirect("PtableroProyecto.aspx");
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {

            }
        }
        else
        {
            mensaje.InnerText = "Debe subir una imagen";
        }

    }

    private void actualizar()
    {
        if (img.HasFile)
        {
            // Verifica si el archivo es una imagen
            string extension = Path.GetExtension(img.FileName);
            if (extension != "")
            {
                string fileName = Path.GetFileName(img.PostedFile.FileName);
                string filePath = Server.MapPath("../../Imagenes/Proyecto/") + txtnombre.Text + ".jpg";
                img.SaveAs(filePath);

                string rutaImagen = txtnombre.Text + ".jpg";
                try
                {
                    cProyecto.Actualizar_CProyecto_A_CC(int.Parse(Session["EditarProyecto"].ToString()), txtnombre.Text, desc.Text, ubicacion.Text, byte.Parse(estado.SelectedValue), rutaImagen, byte.Parse(horas.Text), DateTime.Parse(inicio.Text), DateTime.Parse(fin.Text), DateTime.Parse(creacion.Text), int.Parse(sede.SelectedValue));
                    mensaje.InnerText = "El proyecto se actualizo correctamente";
                    Session["EditarProyecto"] = 0;
                    Response.Redirect("PtableroProyecto.aspx");
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {

            }
        }
        else
        {
            mensaje.InnerText = "Debe subir una imagen";
        }

    }


    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (int.Parse(Session["EditarProyecto"].ToString()) > 0)
        {
            actualizar();
        }
        else
        {
            crearProyecto();
        }

    }

}